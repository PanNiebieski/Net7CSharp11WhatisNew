

//It's a "native (platform-specific) size integer."
//It's internally represented as void* but exposed as
//an integer.
//You can use it whenever you need to store an
//unmanaged pointer and don't want to use unsafe code.
//IntPtr.Zero is effectively NULL (a null pointer).

IntPtr intPtr = IntPtr.Zero;
UIntPtr uintPtr = UIntPtr.Zero;

nint intPtr2 = nint.Zero;
nuint uintPtr2 = nuint.Zero;

//You can use IntPtr.Size to find out whether
//you're running in a 32-bit or 64-bit process,
//as it will be 4 or 8 bytes respectively.

nint intPtr3 = nint.Size;
