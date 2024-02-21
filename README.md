## About this project
This work was conducted by me and my good friend Jonas (kram@itu.dk) in 2021. We used this as a learning experience, while we were learning our first programming language ever, F#.

The program cat is a UNIX-program, which concatenates files. Like the program that exists on
both Linux and macOS. When passing two text files to cat, e.g. a.txt and b.txt, then the program
prints the contents of file a.txt followed by the contents of b.txt to the screen. 

In this program, we a version of cat, as well as a reverse version of cat called "tac", which prints the files in reverse order and prints each file from the last to the first character.

### Cat works like this:

If b.txt contains the characters 123\n456\n then cat a.txt b.txt will output abc\ndef\n123\n456\n to the screen.

### Tac works like this:
If we had the same b.txt and a.txt files, tac would output: 
654\n321\fed\ncba\n


## READ ME: 

To run the code: 
1. Open a  command prompt, e.g. mono command prompt
2. Locate the files readNWrite.fs, cat.fsx, tac.fsx and countLinks.fsx in the src-folder. 
3. When these file has been located in the folder, type in "fsharpc -a readNWrite.fs"  
This will make fsharp enter compile mode. 
4. When this is done correctly, a dll file will be generated and you can run "cat.fsx", "tac.fsx" and "countLinks.fsx"
5. Type in "fsharpc -r readNWrite.dll cat.fsx" after you have completed step 4. This will create an .exe file
6. Now type in "cat.fsx" to run the code. 
7. Repeat steps 5 and 6 with "tac.fsx" and "countLinks.fsx"

// Examples: 

1. When running cat, you give it two text files. For example when we run a file1.txt with content "abc\ndef\n" and file2.txt with content "123\n456\n". 
Cat then contatenates the two files into "abc\ndef\n123\n456\n". When we try to run cat with invalid files, cat will not work. 

2. When running tac, you give it two text files. For example when we run file1 with content "abc\ndef\n" and file2 with content "123\n456".
Tac then outputs "654\n321\nfed\ncba\n" in the console. We also tried typing in invalid input such as "file1.txt" and "file2" and the function
does not contecatenate the input, since in this case, the last file won't be found when the ".txt"-ending isn't spelled out. 

3. When running countLinks, you give it an url.
For example a link to a website containing x links, countLinks will return an integer, 
corresponding to the number of links found in the website. 


