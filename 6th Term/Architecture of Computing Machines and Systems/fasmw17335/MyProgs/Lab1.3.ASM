; lab1_3.asm
format PE GUI 4.0
include 'win32ax.inc'

.data
  Caption db '–езультат',0
  Text db 'Ќовое число = %d',0
  buf rb 256
  B dd 123

.code
  start:
    mov eax, [B]
    mov ebx, 100
    cdq
    div ebx            ; eax = сотни, edx = остаток (дес€тки и единицы)
    push eax           ; сохраним сотни
    mov eax, edx
    mov ebx, 10
    cdq
    div ebx            ; eax = дес€тки, edx = единицы
    pop ebx            ; ebx = сотни
    ; новое число = сотни*100 + единицы*10 + дес€тки
    imul ebx, 100
    mov ecx, edx       ; единицы
    imul ecx, 10
    add ebx, ecx
    add ebx, eax       ; + дес€тки
    mov eax, ebx
    invoke wsprintf, addr buf, addr Text, eax
    invoke MessageBox, 0, addr buf, addr Caption, MB_OK
    invoke ExitProcess, 0
  .end start