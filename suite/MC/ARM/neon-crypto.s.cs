# CS_ARCH_ARM, CS_MODE_ARM, None
0x42,0x03,0xb0,0xf3 = aesd.8 q0, q1
0x02,0x03,0xb0,0xf3 = aese.8 q0, q1
0xc2,0x03,0xb0,0xf3 = aesimc.8 q0, q1
0x82,0x03,0xb0,0xf3 = aesmc.8 q0, q1
0xc2,0x02,0xb9,0xf3 = sha1h.32 q0, q1
0x82,0x03,0xba,0xf3 = sha1su1.32 q0, q1
0xc2,0x03,0xba,0xf3 = sha256su0.32 q0, q1
0x44,0x0c,0x02,0xf2 = sha1c.32 q0, q1, q2
0x44,0x0c,0x22,0xf2 = sha1m.32 q0, q1, q2
0x44,0x0c,0x12,0xf2 = sha1p.32 q0, q1, q2
0x44,0x0c,0x32,0xf2 = sha1su0.32 q0, q1, q2
0x44,0x0c,0x02,0xf3 = sha256h.32 q0, q1, q2
0x44,0x0c,0x12,0xf3 = sha256h2.32 q0, q1, q2
0x44,0x0c,0x22,0xf3 = sha256su1.32 q0, q1, q2
0xa1,0x0e,0xe0,0xf2 = vmull.p64 q8, d16, d17
