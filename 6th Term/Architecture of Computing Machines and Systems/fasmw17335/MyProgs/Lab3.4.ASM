; Lab3_4

format PE console
include 'win32a.inc'

entry start

section '.data' data readable writeable
    msg db '%d ', 0
    newline db 13, 10, 0
    first_flag dd 0   ; для форматирования

section '.code' code readable executable

start:
    mov     ecx, 1
    mov     ebx, 0      ; флаг первого вывода

.loop_n:
    cmp     ecx, 300
    jg      .done

    xor     edx, edx
    mov     esi, 1      ; делитель
    xor     edi, edi    ; счётчик делителей

.loop_d:
    cmp     esi, ecx
    jg      .check

    mov     eax, ecx
    xor     edx, edx
    div     esi
    test    edx, edx
    jnz     .next_d
    inc     edi         ; найден делитель

.next_d:
    inc     esi
    jmp     .loop_d

.check:
    cmp     edi, 5
    jne     .next_n

    ; вывод числа
    push    ecx
    push    msg
    call    [printf]
    add     esp, 8
    mov     [first_flag], 1

.next_n:
    inc     ecx
    jmp     .loop_n

.done:
    push    newline
    call    [printf]
    add     esp, 4

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