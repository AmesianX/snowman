# CS_ARCH_MIPS, CS_MODE_32+CS_MODE_MICRO, None
0xa4,0x1c,0x08,0x00 = lb $5, 8($4)
0xc4,0x14,0x08,0x00 = lbu $6, 8($4)
0x44,0x3c,0x08,0x00 = lh $2, 8($4)
0x82,0x34,0x08,0x00 = lhu $4, 8($2)
0xc5,0xfc,0x04,0x00 = lw $6, 4($5)
0xa4,0x18,0x08,0x00 = sb $5, 8($4)
0x44,0x38,0x08,0x00 = sh $2, 8($4)
0xa6,0xf8,0x04,0x00 = sw $5, 4($6)