# PAK-Manipulator
 
 GUI for manipulating PAK files for the Neversoft Guitar Hero Games.

## Usage

### Extracting

To extract a PAK file, simply drag and drop it onto the text box in the PAK Extract tab and click Extract. The program will create a folder with the same name as the PAK file and extract all the files into it.

When extracting, you have the option of converting any ".qb" files to decompiled ".q" files. This is useful for viewing the contents of the ".qb" files. To convert the files, check the "Convert .qb files to text" checkbox.

### Rebuilding

Rebuilding a PAK file cannot be done as a batch operation. The program will only rebuild one PAK file at a time. 

To rebuild a PAK file, drag and drop the folder containing the extracted PAK files onto the text box in the PAK Compile tab and click Compile. The program will create a PAK file with the same name as the folder and place it in the same directory as the folder. Selecting a different console with the radio buttons will change the extension the PAK file is saved as.

Any ".q" files found in the folder will be compiled to ".qb" files.

## Supported Games

* Guitar Hero 3
* Guitar Hero Aerosmith
* Guitar Hero World Tour

## Supported Platforms

* PC
* Xbox 360
* PlayStation 3