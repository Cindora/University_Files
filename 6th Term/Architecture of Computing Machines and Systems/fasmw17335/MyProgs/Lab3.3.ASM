; Lab3_3

format PE console
include 'win32a.inc'

entry start

section '.data' data readable writeable
    count dd 0
    msg db 'Kol-vo chisel: %d', 13, 10, 0

section '.code' code readable executable

start:
    mov     ecx, 100          ; начальное число
    xor     ebx, ebx          ; счётчик (будет в EBX)

.loop:
    cmp     ecx, 500
    jg      .done

    ; вычисление суммы цифр
    mov     eax, ecx
    xor     edx, edx
    mov     edi, 100
    div     edi               ; eax = сотни, edx = остаток
    mov     esi, eax          ; сохраняем сотни
    mov     eax, edx
    xor     edx, edx
    mov     edi, 10
    div     edi               ; eax = десятки, edx = единицы
    add     esi, eax          ; сотни + десятки
    add     esi, edx          ; + единицы
    cmp     esi, 15
    jne     .next
    inc     ebx               ; увеличить счётчик

.next:
    inc     ecx
    jmp     .loop

.done:
    mov     [count], ebx

    ; вывод
    push    dword [count]
    push    msg
    call    [printf]
    add     esp, 8

    call [getchar]

    push    0
    call    [ExitProcess]

section '.idata' import data readable writeable
    library kernel32, 'kernel32.dll', \
            msvcrt,   'msvcrt.dll'

    import kernel32, \
           ExitProcess, 'ExitProcess'

    import msvcrt, \
           printf, 'printf', \
           getchar, 'getchar'