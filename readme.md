# HID Report Descriptor Editor1

This tool allows you to create, edit and validate HID Report Descriptors.

## Features

* Create, edit and delete report short items
* Saving a report in a binary file (.HID), as a byte array
* Export a report contant to file and a report size value to a export file

## Latest Versions

* 0.1.0
	* Minimal functionality implemented.
	
### Compatibility

This application requires at least:
* Windows
* .Net Core 3.1 or above

## Usage

	1. Download applicatrion
	2. Run HID Report Descriptor Editor.exe
	3. (optional) For register file extension select menu item Tools -> Register file extension
	4. Profit

TODO изображение UI с репортом

TODO пример использования

TODO настройка IDE скрипт pre-build

TODO настройка IDE приложение по-умолчанию для файла

### Command Line Arguments

* `--h | --help | /h | /help` - Show helpful about all command line arguments
* `--e | --export <*.hid> <outfile>` - Exports the report descriptor to a C header file with the following variables in it:
	* `${REPORT_SIZE}` - report size (in bytes)
	* `${REPORT_CONTENT}` - report byte array (formatted)
* `--l | --language <value>` - Set UI language, supported:
    * `en-US` - English (US)
    * `ru-RU` - Russian (Russia)

## Authors

* **Banko Viktor S.** - *Initial work* - [MrWinston34](https://bitbucket.org/MrWinston34/)

## License

[MIT](https://choosealicense.com/licenses/mit/)

## Acknowledgments

* [HID Descriptor Tool](https://www.usb.org/document-library/hid-descriptor-tool) - Descriptor Tool, version 2.4 (2001 year)
