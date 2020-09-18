using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static HID_Report_Descriptor_Editor.Utils.NativeMethods;

namespace HID_Report_Descriptor_Editor.Utils
{
    /* НОВАЯ
     * Implementing a Custom File Format (https://docs.microsoft.com/en-us/windows/win32/shell/customizing-file-types-bumper)
     * Список свойст и ключей https://windowssucks.wordpress.com/file-type-registration/
     */

    public class Verb
    {
        /// <summary>
        /// Внутреннее имя действия.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отображаемое названи действия, если не определено отображается значение поля <see cref="Name"/>.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Иконка пункта меню.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Пункт меню отображается только в расширенном режиме (при открытии меню с зажатой клавишей <b>Shift</b>).
        /// </summary>
        public bool IsExtended { get; set; }

        /// <summary>
        /// Выполняемая команда при активации действия.
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Значения флага <see cref="SFGAO"/> атрибутов оболочки для элемента могут быть протестированы, 
        /// чтобы определить, следует ли включить или отключить глагол.
        /// Определяет битовую маску значения <see cref="AttributeValue"/> тестируемых битов.
        /// </summary>
        public SFGAO AttributeMask
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Определяет значение <see cref="SFGAO"/> тестируемых битов.
        /// </summary>
        public SFGAO AttributeValue
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Указывает ноль для глаголов элемента или ненулевое значение для глаголов фонового контекстного меню.
        /// </summary>
        public uint ImpliedSelectionModel
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Verb(string name, string command)
        {
            Name = name;
            Command = command;
        }
    }

    #region enum SFGAO

    /// <summary>
    /// Attributes that can be retrieved on an item (file or folder) or set of items.
    /// </summary>
    // https://docs.microsoft.com/en-us/windows/win32/shell/sfgao
    [Flags]
    public enum SFGAO : uint
    {
        /// <summary>
        /// The specified items can be copied.
        /// </summary>
        SFGAO_CANCOPY = 0x00000001,
        /// <summary>
        /// The specified items can be moved.
        /// </summary>
        SFGAO_CANMOVE = 0x00000002,
        /// <summary>
        /// Shortcuts can be created for the specified items.
        /// </summary>
        SFGAO_CANLINK = 0x00000004,
        /// <summary>
        /// The specified items can be bound to an <b>IStorage</b> object through <b>IShellFolder::BindToObject</b>.
        /// </summary>
        SFGAO_STORAGE = 0x00000008,
    }

    #endregion

    #region enum FileTypeAttributeFlags

    [Flags]
    public enum FileTypeAttributeFlags : uint
    {
        /// <summary>
        /// No <see cref="FileTypeAttributeFlags"/> options set.
        /// </summary>
        FTA_None = 0x00000000,
        /// <summary>
        /// Excludes the file type.
        /// </summary>
        FTA_Exclude = 0x00000001,
        /// <summary>
        /// Shows file types, such as folders, that are not associated with a file name extension.
        /// </summary>
        FTA_Show = 0x00000002,
        /// <summary>
        /// Indicates that the file type has a file name extension.
        /// </summary>
        FTA_HasExtension = 0x00000004,
        /// <summary>
        /// Prohibits editing of the registry entries associated with this file type, the 
        /// addition of new entries, and the deletion or modification of existing entries.
        /// </summary>
        FTA_NoEdit = 0x00000008,
        /// <summary>
        /// Prohibits deletion of the registry entries associated with this file type.
        /// </summary>
        FTA_NoRemove = 0x00000010,
        /// <summary>
        /// Prohibits the addition of new verbs to the file type.
        /// </summary>
        FTA_NoNewVerb = 0x00000020,
        /// <summary>
        /// Prohibits the modification or deletion of canonical <i>verbs</i> such as <b>open</b> and <b>print</b>.
        /// </summary>
        FTA_NoEditVerb = 0x00000040,
        /// <summary>
        /// Prohibits the deletion of canonical <i>verbs</i> such as <b>open</b> and <b>print</b>.
        /// </summary>
        FTA_NoRemoveVerb = 0x00000080,
        /// <summary>
        /// Prohibits the modification or deletion of the description of the file type.
        /// </summary>
        FTA_NoEditDesc = 0x00000100,
        /// <summary>
        /// Prohibits the modification or deletion of the icon assigned to the file type.
        /// </summary>
        FTA_NoEditIcon = 0x00000200,
        /// <summary>
        /// Prohibits the modification of the <i>default verb</i>.
        /// </summary>
        FTA_NoEditDflt = 0x00000400,
        /// <summary>
        /// Prohibits the modification of the <i>commands</i> associated with verbs.
        /// </summary>
        FTA_NoEditVerbCmd = 0x00000800,
        /// <summary>
        /// Prohibits the modification or deletion of verbs.
        /// </summary>
        FTA_NoEditVerbExe = 0x00001000,
        /// <summary>
        /// Prohibits the modification or deletion of the entries related to DDE.
        /// </summary>
        FTA_NoDDE = 0x00002000,
        /// <summary>
        /// Prohibits the modification or deletion of the content type and default extension entries.
        /// </summary>
        FTA_NoEditMIME = 0x00008000,
        /// <summary>
        /// Indicates that the file type's <b>open</b> verb can be safely invoked for downloaded files.
        /// </summary>
        FTA_OpenIsSafe = 0x00010000,
        /// <summary>
        /// Prevents the <b>Never ask me</b> check box from being enabled. Use of this flag means <b>FTA_OpenIsSafe</b> 
        /// is not respected and <b>AssocIsDangerous</b> always returns <see cref="true"/>.
        /// </summary>
        FTA_AlwaysUnsafe = 0x00020000,
        /// <summary>
        /// Prohibits the addition of members of this file type to the Recent Documents folder
        /// </summary>
        FTA_NoRecentDocs = 0x00100000,
        /// <summary>
        /// Marks the file as safe to be passed from a low trust application to a full trust application.
        /// </summary>
        FTA_SafeForElevation = 0x00200000,
        /// <summary>
        /// Ensures that the verbs for the file type are invoked with a URI instead of a downloaded version of the file.
        /// </summary>
        FTA_AlwaysUseDirectInvoke = 0x00400000
    }

    #endregion

    public class FileExtensionHelper
    {
        /// <summary>
        /// Расширение типа файла (с точкой вначале).
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Идентификатор приложения, например: [<i>Vendor or Application</i>]<b>.</b>[<i>Component</i>]<b>.</b>[<i>Version</i>]
        /// </summary>
        public string ProgID { get; set; }

        /// <summary>
        /// Отображаемое описание типа файла.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Локализированное отображаемое описание типа файла, если не указано будет отображаться значение поля <see cref="Description"/>.
        /// </summary>
        public string FriendlyTypeName { get; set; }

        /// <summary>
        /// Краткое справочное сообщение, которое оболочка отображает для этого идентификатора <see cref="ProgID"/>. 
        /// Отображается в диалоговом окне при наведении указателя мыши. 
        /// Для отображения канонических свойств укажите их в формате <b>prop:System.Size;</b>, каноническое имя свойства <b>{fmtid},pid</b>
        /// </summary>
        public string InfoTip { get; set; }

        /// <summary>
        /// Путь до иконки типа файла.
        /// </summary>
        public string DefaultIcon { get; set; }

        /// <summary>
        /// Список действий над файлами.
        /// </summary>
        public Verb[] Verbs { get; set; }

        /// <summary>
        /// Указывает Windows игнорировать этот <see cref="ProgID"/> при определении обработчика 
        /// по умолчанию для общедоступного типа файла.
        /// </summary>
        public bool AllowSilentDefaultTakeOver
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Устанавите AppUserModelID если приложение использует либо автоматически сгенерированные 
        /// системой списки недавних или частых переходов, либо предоставляет настраиваемый список переходов.
        /// </summary>
        public string AppUserModelID
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// <b>Расширение оболочки</b>. <b>CLSID</b> объекта реализуемого интерфейс <b>IDropTarget</b>.
        /// </summary>
        public string DropTarget
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Управляет некоторыми аспектами обработки оболочкой типов файлов, связанных с этим <see cref="ProgID"/>. Тип FILETYPEATTRIBUTEFLAGS
        /// </summary>
        public uint EditFlags
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Установите для записи (По умолчанию) в этом подразделе самую последнюю версию этого <see cref="ProgID"/>.
        /// </summary>
        public string CurVer
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        #region Shell Extension One Value

        /// https://docs.microsoft.com/en-us/windows/win32/shell/reg-shell-exts

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IDataObject</b>.
        /// </summary>
        public const string ExtDataHandler = "DataHandler";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IDropTarget</b>.
        /// </summary>
        public const string ExtDropHandler = "DropHandler";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IExtractIconA</b>/<b>IExtractIconW</b>.
        /// </summary>
        public const string ExtIconHandler = "IconHandler";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IThumbnailProvider</b>.
        /// </summary>
        public const string ExtThumbnailHandler = "{E357FCCD-A995-4576-B01F-234630154E96}";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IQueryInfo</b>.
        /// </summary>
        public const string ExtInfoTipHandler = "{00021500-0000-0000-C000-000000000046}";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IShellLinkA</b>.
        /// </summary>
        public const string ExtShellLinkANSI = "{000214EE-0000-0000-C000-000000000046}";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IShellLinkW</b>.
        /// </summary>
        public const string ExtShellLinkUNICODE = "{000214F9-0000-0000-C000-000000000046}";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IStorage</b>.
        /// </summary>
        public const string ExtStructuredStorage = "{0000000B-0000-0000-C000-000000000046}";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IPropertySetStorage</b>.
        /// </summary>
        public const string ExtPropertyHandler = "PropertyHandler";

        /// <summary>
        /// <b>Только одно значение.</b> Значение ключа по-умолчанию должно содержать <b>CLSID</b>.
        /// Интерфейс для реализации <b>IStartMenuPinnedList</b>.
        /// </summary>
        public const string ExtPinToStartMenu = "{a2a9545d-a0c2-42b4-9708-a0b2badd77c8}";

        #endregion

        #region Shell Extension More Values

        /// <summary>
        /// <b>Множество значений-подключей.</b> 
        /// Интерфейс для реализации <b>IColumnProvider</b>.
        /// </summary>
        public const string ExtColumnHandlers = "ColumnHandlers";

        /// <summary>
        /// <b>Множество значений-подключей.</b> 
        /// Интерфейс для реализации <b>IContextMenu</b>.
        /// </summary>
        public const string ExtContextMenuHandlers = "ContextMenuHandlers";

        /// <summary>
        /// <b>Множество значений-подключей.</b> 
        /// Интерфейс для реализации <b>ICopyHook</b>.
        /// </summary>
        public const string ExtCopyHookHandlers = "CopyHookHandlers";

        /// <summary>
        /// <b>Множество значений-подключей.</b> 
        /// Интерфейс для реализации <b>IContextMenu</b>.
        /// </summary>
        public const string ExtDragDropHandlers = "DragDropHandlers";

        /// <summary>
        /// <b>Множество значений-подключей.</b> 
        /// Интерфейс для реализации <b>IShellPropSheetExt</b>.
        /// </summary>
        public const string ExtPropertySheetHandlers = "PropertySheetHandlers";

        #endregion

        /// <summary>
        /// The presence of that subkey tells the system that the handler is a preview handler.
        /// Нужно зарегистровать <b>CLSID</b> реализующий интерфейс <b>I</b>.
        /// <b>HKEY_CLASSES_ROOT\CLSID\<{clsid}></b>
        /// Интерфейс для реализации <b>s</b>.
        /// </summary>
        public const string ExtPreviewHandler = "{8895b1c6-b41f-4c1c-a562-0d564250836f}";

        /// <summary>
        /// Зарегистрировать тип файла.
        /// </summary>
        public void Register()
        {
            using var user_classes = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\", true);
            using var ext = user_classes.CreateSubKey(Extension);
            using var prog_id = user_classes.CreateSubKey(ProgID);
            using var prog_id_deficon = prog_id.CreateSubKey("DefaultIcon");
            ext.SetValue(string.Empty, ProgID);
            prog_id.SetValue(string.Empty, Description);

            if (!string.IsNullOrWhiteSpace(FriendlyTypeName))
                prog_id.SetValue("FriendlyTypeName", FriendlyTypeName);

            if (!string.IsNullOrWhiteSpace(InfoTip))
                prog_id.SetValue("InfoTip", InfoTip);

            if (!string.IsNullOrWhiteSpace(DefaultIcon))
                prog_id_deficon.SetValue(string.Empty, DefaultIcon);

            if (Verbs.Length > 0)
            {
                using var user_shell = prog_id.CreateSubKey("shell");
                foreach (var verb in Verbs)
                {
                    using var user_verb = user_shell.CreateSubKey(verb.Name);
                    using var user_verb_cmd = user_verb.CreateSubKey("Command");

                    user_verb.SetValue(string.Empty, verb.Title);

                    if (!string.IsNullOrWhiteSpace(verb.Icon))
                        user_verb.SetValue("Icon", verb.Icon);

                    if (verb.IsExtended)
                        user_verb.SetValue("Extended", string.Empty);

                    user_verb_cmd.SetValue(string.Empty, verb.Command);
                }
            }
        }

        /// <summary>
        /// Удалить зарегистрированный ранее тип файла.
        /// </summary>
        public void Unregister()
        {
            using var user_classes = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\", true);
            user_classes.DeleteSubKeyTree(Extension);
            user_classes.DeleteSubKeyTree(ProgID);
        }
    }

    public static class FileExtensionApplication
    {
        private static readonly FileExtensionHelper helper = new FileExtensionHelper()
        {
            ProgID = GetProgID(),
            Extension = Program.FileExtension,
            Description = Program.FileExtensionCaption,
            InfoTip = "prop:FileDescription;Company;FileVersion;Create;Size",
            DefaultIcon = $"{Process.GetCurrentProcess().MainModule.FileName},-{2}", // TODO иконка типа файла
            Verbs = new Verb[]
                {
                    new Verb("open", $"{Process.GetCurrentProcess().MainModule.FileName} %1")
                    {
                        Title = "Открыть",
                    },
                    new Verb("export", string.Format("{0} --export %1 out.h", Process.GetCurrentProcess().MainModule.FileName))
                    {
                        Title = "Экспортировать",
                        // TODO иконка пункта меню экспорта
                    },
                }
        };

        private static string GetProgID()
        {
            return Application.CompanyName.Replace(' ', '_') + '.' + Application.ProductName.Replace(' ', '_') + '.' + Application.ProductVersion.Split('.')[0];
        }

        public static void Register()
        {
            try
            {
                helper.Register();
                SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
                MessageBox.Show("Succsess", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Unregister()
        {
            try
            {
                helper.Unregister();
                SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
                MessageBox.Show("Succsess", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}