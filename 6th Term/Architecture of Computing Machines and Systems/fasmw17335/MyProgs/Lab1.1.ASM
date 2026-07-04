; lab1_1.asm
format PE GUI 4.0
include 'win32ax.inc'

.data
  Caption db 'Результат',0
  Text db 'Количество квадратов = %d',0
  buf rb 256
  a dd 543
  b dd 130

.code
  start:
    mov eax, [a]
    xor edx, edx
    div [b]          ; eax = 543 / 130 = 4 (целая часть)
    invoke wsprintf, addr buf, addr Text, eax
    invoke MessageBox, 0, addr buf, addr Caption, MB_OK
    invoke ExitProcess, 0
  .end start