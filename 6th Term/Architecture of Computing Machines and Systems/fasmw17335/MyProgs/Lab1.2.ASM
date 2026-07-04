; lab1_2.asm
format PE GUI 4.0
include 'win32ax.inc'

.data
  Caption db 'Результат',0
  Text db 'y = %d',0
  buf rb 256
  a dd 2
  b dd 3

.code
  start:
    mov eax, [a]
    imul eax, eax      ; a^2
    mov ebx, eax       ; сохраним a^2
    imul eax, 3        ; 3*a^2
    sub eax, [b]       ; 3*a^2 - b (числитель1)
    mov ecx, [a]
    add ecx, [b]       ; a+b (знаменатель1)
    cdq
    idiv ecx           ; eax = (3a^2-b)/(a+b)
    push eax           ; сохраним частное1

    ; вычислим вторую часть: 3*(a^2-1)
    mov eax, ebx       ; a^2
    sub eax, 1
    imul eax, 3        ; 3*(a^2-1)
    pop ebx            ; восстановим частное1
    sub ebx, eax       ; y = частное1 - второе
    mov eax, ebx

    invoke wsprintf, addr buf, addr Text, eax
    invoke MessageBox, 0, addr buf, addr Caption, MB_OK
    invoke ExitProcess, 0
  .end start