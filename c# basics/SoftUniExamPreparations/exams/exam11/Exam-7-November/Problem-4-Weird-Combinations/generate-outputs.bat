csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    WeirdCombinations.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
del *.exe
PAUSE