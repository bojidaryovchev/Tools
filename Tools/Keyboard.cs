namespace Tools
{
    using System;
    using System.Threading;
    using System.Runtime.InteropServices;

    public static class Keyboard
    {
        #region Libraries

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const uint KEYEVENTF_KEYUP = 0x0002;

        #endregion

        #region Letters

        private const byte A = 0x41;
        private const byte B = 0x42;
        private const byte C = 0x43;
        private const byte D = 0x44;
        private const byte E = 0x45;
        private const byte F = 0x46;
        private const byte G = 0x47;
        private const byte H = 0x48;
        private const byte I = 0x49;
        private const byte J = 0x4A;
        private const byte K = 0x4B;
        private const byte L = 0x4C;
        private const byte M = 0x4D;
        private const byte N = 0x4E;
        private const byte O = 0x4F;
        private const byte P = 0x50;
        private const byte Q = 0x51;
        private const byte R = 0x52;
        private const byte S = 0x53;
        private const byte T = 0x54;
        private const byte U = 0x55;
        private const byte V = 0x56;
        private const byte W = 0x57;
        private const byte X = 0x58;
        private const byte Y = 0x59;
        private const byte Z = 0x5A;

        #endregion

        #region Numbers

        private const byte Zero = 0x30;
        private const byte One = 0x31;
        private const byte Two = 0x32;
        private const byte Three = 0x33;
        private const byte Four = 0x34;
        private const byte Five = 0x35;
        private const byte Six = 0x36;
        private const byte Seven = 0x37;
        private const byte Eight = 0x38;
        private const byte Nine = 0x39;

        #endregion

        #region SpecialSymbols

        private const byte Space = 0x20;
        private const byte GraveAccent = 0xC0;
        private const byte Minus = 0xBD;
        private const byte EqualSign = 0xBB;
        private const byte LeftSquareBracket = 0xDB;
        private const byte RightSquareBracket = 0xDD;
        private const byte Semicolon = 0xBA;
        private const byte SingleQuote = 0xDE;
        private const byte Backslash = 0xDC;
        private const byte Comma = 0xBC;
        private const byte Dot = 0xBE;
        private const byte Slash = 0xBF;

        #endregion

        #region SpecialKeys

        private const byte F1 = 0x70;
        private const byte F2 = 0x71;
        private const byte F3 = 0x72;
        private const byte F4 = 0x73;
        private const byte F5 = 0x74;
        private const byte F6 = 0x75;
        private const byte F7 = 0x76;
        private const byte F8 = 0x77;
        private const byte F9 = 0x78;
        private const byte F10 = 0x79;
        private const byte F11 = 0x7A;
        private const byte F12 = 0x7B;
        private const byte Esc = 0x1B;
        private const byte Tab = 0x09;
        private const byte Shift = 0xA1;
        private const byte Enter = 0x0D;

        #endregion

        public static void Press(KeyboardKey key)
        {
            switch (key)
            {
                case KeyboardKey.LowercaseA:
                    keybd_event(A, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseB:
                    keybd_event(B, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(B, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseC:
                    keybd_event(C, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(C, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseD:
                    keybd_event(D, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(D, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseE:
                    keybd_event(E, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(E, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseF:
                    keybd_event(F, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseG:
                    keybd_event(G, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(G, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseH:
                    keybd_event(H, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(H, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseI:
                    keybd_event(I, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(I, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseJ:
                    keybd_event(J, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(J, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseK:
                    keybd_event(K, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(K, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseL:
                    keybd_event(L, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(L, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseM:
                    keybd_event(M, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(M, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseN:
                    keybd_event(N, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(N, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseO:
                    keybd_event(O, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(O, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseP:
                    keybd_event(P, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(P, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseQ:
                    keybd_event(Q, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Q, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseR:
                    keybd_event(R, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(R, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseS:
                    keybd_event(S, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(S, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseT:
                    keybd_event(T, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(T, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseU:
                    keybd_event(U, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(U, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseV:
                    keybd_event(V, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(V, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseW:
                    keybd_event(W, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(W, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseX:
                    keybd_event(X, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(X, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseY:
                    keybd_event(Y, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Y, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LowercaseZ:
                    keybd_event(Z, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Z, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseA:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(A, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseB:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(B, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(B, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseC:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(C, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(C, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseD:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(D, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(D, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseE:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(E, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(E, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseF:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseG:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(G, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(G, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseH:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(H, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(H, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseI:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(I, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(I, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseJ:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(J, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(J, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseK:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(K, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(K, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseL:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(L, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(L, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseM:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(M, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(M, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseN:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(N, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(N, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseO:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(O, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(O, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseP:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(P, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(P, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseQ:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Q, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Q, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseR:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(R, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(R, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseS:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(S, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(S, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseT:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(T, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(T, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseU:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(U, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(U, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseV:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(V, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(V, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseW:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(W, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(W, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseX:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(X, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(X, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseY:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Y, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Y, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.UppercaseZ:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Z, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Z, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Zero:
                    keybd_event(Zero, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Zero, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.One:
                    keybd_event(One, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(One, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Two:
                    keybd_event(Two, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Two, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Three:
                    keybd_event(Three, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Three, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Four:
                    keybd_event(Four, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Four, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Five:
                    keybd_event(Five, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Five, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Six:
                    keybd_event(Six, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Six, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Seven:
                    keybd_event(Seven, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Seven, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Eight:
                    keybd_event(Eight, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Eight, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Nine:
                    keybd_event(Nine, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Nine, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.ExclamationMark:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(One, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(One, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.At:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Two, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Two, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Sharp:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Three, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Three, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.DollarSign:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Four, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Four, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Percent:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Five, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Five, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Caret:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Six, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Six, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Ampersand:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Seven, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Seven, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Asterisk:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Eight, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Eight, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LeftBracket:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Nine, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Nine, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.RightBracket:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Zero, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Zero, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Space:
                    keybd_event(Space, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Space, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.GraveAccent:
                    keybd_event(GraveAccent, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(GraveAccent, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Minus:
                    keybd_event(Minus, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Minus, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.EqualSign:
                    keybd_event(EqualSign, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(EqualSign, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LeftSquareBracket:
                    keybd_event(LeftSquareBracket, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(LeftSquareBracket, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.RightSquareBracket:
                    keybd_event(RightSquareBracket, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(RightSquareBracket, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Semicolon:
                    keybd_event(Semicolon, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Semicolon, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.SingleQuote:
                    keybd_event(SingleQuote, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(SingleQuote, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Backslash:
                    keybd_event(Backslash, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Backslash, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Comma:
                    keybd_event(Comma, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Comma, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Dot:
                    keybd_event(Dot, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Dot, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Slash:
                    keybd_event(Slash, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Slash, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Tilde:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(GraveAccent, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(GraveAccent, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Underscore:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Minus, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Minus, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Plus:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(EqualSign, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(EqualSign, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LeftCurlyBracket:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(LeftSquareBracket, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(LeftSquareBracket, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.RightCurlyBracket:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(RightSquareBracket, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(RightSquareBracket, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.Colon:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Semicolon, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Semicolon, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.DoubleQuotes:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(SingleQuote, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(SingleQuote, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.VerticalBar:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Backslash, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Backslash, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.LessThan:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Comma, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Comma, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.GreaterThan:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Dot, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Dot, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardKey.QuestionMark:
                    keybd_event(Shift, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Slash, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Slash, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(Shift, 0, KEYEVENTF_KEYUP, 0);
                    break;
            }
        }

        public static void Type(string text, int? delay = null)
        {
            foreach (char symbol in text)
            {
                Press((KeyboardKey)symbol);

                if (delay != null)
                {
                    Thread.Sleep((int)delay);
                }
            }
        }

        public static void PressSpecial(KeyboardSpecialKey key)
        {
            switch (key)
            {
                case KeyboardSpecialKey.Esc:
                    keybd_event(Esc, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Esc, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.Tab:
                    keybd_event(Tab, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Tab, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.Enter:
                    keybd_event(Enter, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(Enter, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F1:
                    keybd_event(F1, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F1, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F2:
                    keybd_event(F2, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F2, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F3:
                    keybd_event(F3, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F3, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F4:
                    keybd_event(F4, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F4, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F5:
                    keybd_event(F5, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F5, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F6:
                    keybd_event(F6, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F6, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F7:
                    keybd_event(F7, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F7, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F8:
                    keybd_event(F8, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F8, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F9:
                    keybd_event(F9, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F9, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F10:
                    keybd_event(F10, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F10, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F11:
                    keybd_event(F11, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F11, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case KeyboardSpecialKey.F12:
                    keybd_event(F12, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    keybd_event(F12, 0, KEYEVENTF_KEYUP, 0);
                    break;
            }
        }
    }
}
