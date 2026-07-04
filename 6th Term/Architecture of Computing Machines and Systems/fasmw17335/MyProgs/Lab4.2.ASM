; Lab4_2

format PE console
include 'win32a.inc'

entry start

section '.data' data readable writeable
    arr dd -5, 12, -3, 9, 0, 6, -8, 15, 4, 21
    k dd 3
    msg_found db 'Nomer elementa: %d', 13, 10, 0
    msg_not db 'Element not found', 13, 10, 0

section '.code' code readable executable

start:
    mov     esi, arr
    mov     ecx, 10          ; количество элементов
    mov     eax, [k]

    ; поиск с конца
    mov     edi, ecx         ; индекс (начиная с 9)
.search:
    dec     edi
    cmp     edi, 0
    jl      .not_found

    mov     ebx, [esi + edi*4]
    test    ebx, ebx
    jle     .search          ; не положительный

    ; проверка кратности k
    xor     edx, edx
    div     ebx              ; делим ebx на k? лучше делить ebx на k
    mov     eax, ebx
    xor     edx, edx
    div     [k]
    test    edx, edx
    jnz     .search

    ; найден, номер = edi + 1
    inc     edi
    push    edi
    push    msg_found
    call    [printf]
    add     esp, 8
    jmp     .exit

.not_found:
    push    msg_not
    call    [printf]
    add     esp, 4

.exit:
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