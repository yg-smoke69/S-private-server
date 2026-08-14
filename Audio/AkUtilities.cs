using Il2CppDummyDll;

[Token(Token = "0x2003DD8")]
public class AkUtilities
{
	[Token(Token = "0x2003DD9")]
	public class ShortIDGenerator
	{
		[Token(Token = "0x401A42F")]
		private const uint s_prime32 = 16777619u;

		[Token(Token = "0x401A430")]
		private const uint s_offsetBasis32 = 2166136261u;

		[Token(Token = "0x401A431")]
		[FieldOffset(Offset = "0x0")]
		private static byte s_hashSize;

		[Token(Token = "0x401A432")]
		[FieldOffset(Offset = "0x4")]
		private static uint s_mask;

		[Token(Token = "0x17001B2C")]
		public static byte HashSize
		{
			[Token(Token = "0x60192B5")]
			[Address(RVA = "0x2EBF094", Offset = "0x2EBF094", VA = "0x2EBF094")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60192B6")]
			[Address(RVA = "0x2EBEFD0", Offset = "0x2EBEFD0", VA = "0x2EBEFD0")]
			set
			{
			}
		}

		[Token(Token = "0x60192B3")]
		[Address(RVA = "0x2EBEFC8", Offset = "0x2EBEFC8", VA = "0x2EBEFC8")]
		static ShortIDGenerator()
		{
		}

		[Token(Token = "0x60192B4")]
		[Address(RVA = "0x2EBF08C", Offset = "0x2EBF08C", VA = "0x2EBF08C")]
		public ShortIDGenerator()
		{
		}

		[Token(Token = "0x60192B7")]
		[Address(RVA = "0x2EBCDBC", Offset = "0x2EBCDBC", VA = "0x2EBCDBC")]
		public static uint Compute(string in_name)
		{
			return default(uint);
		}
	}

	[Token(Token = "0x60192B1")]
	[Address(RVA = "0x2EBEEA4", Offset = "0x2EBEEA4", VA = "0x2EBEEA4")]
	public AkUtilities()
	{
	}

	[Token(Token = "0x60192B2")]
	[Address(RVA = "0x2EBEEAC", Offset = "0x2EBEEAC", VA = "0x2EBEEAC")]
	public static string PathCombine(string[] args)
	{
		return null;
	}
}
