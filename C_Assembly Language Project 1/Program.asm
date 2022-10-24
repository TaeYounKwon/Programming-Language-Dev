; AUTHOR: Jack Kwon
; DATE: 2/1/2022
; DESCRIPTION: Assignment 3.2.3

.586
.MODEL FLAT

.STACK  4096            ; reserve 4096-byte stack

.DATA                   ; reserve storage for data
number  DWORD   -105
diff    DWORD   ?       ; changed from sum     DWORD   ?
                        ; now diff to storage for data after calculation

.CODE                           ; start of main program code
main    PROC
        mov     eax, number     ; first number to EAX
        sub     eax, 1000	    ; subtract the number from EAX
        mov     diff, eax       ; last EAX to diff

        mov   eax, 0            ; exit with return code 0
        ret
main    ENDP

END                             ; end of source code
