using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B7")]
public class ResWithTimeoutFileLoader : ResFileLoader
{
	[Token(Token = "0x20040B8")]
	private class TimeoutTimer
	{
		[Token(Token = "0x401B2FA")]
		[FieldOffset(Offset = "0x8")]
		private float m_EndTime;

		[Token(Token = "0x601A564")]
		[Address(RVA = "0x3300B2C", Offset = "0x3300B2C", VA = "0x3300B2C")]
		public TimeoutTimer()
		{
		}

		[Token(Token = "0x601A565")]
		[Address(RVA = "0x3300C18", Offset = "0x3300C18", VA = "0x3300C18")]
		public void Start(float gameTime, float timeout)
		{
		}

		[Token(Token = "0x601A566")]
		[Address(RVA = "0x3300BFC", Offset = "0x3300BFC", VA = "0x3300BFC")]
		public bool IsExpired(float gameTime)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B2F8")]
	protected const float DEFAULT_TIMEOUT = 5f;

	[Token(Token = "0x401B2F9")]
	[FieldOffset(Offset = "0x2C")]
	private TimeoutTimer m_Timeout;

	[Token(Token = "0x601A560")]
	[Address(RVA = "0x3300720", Offset = "0x3300720", VA = "0x3300720")]
	public ResWithTimeoutFileLoader()
	{
	}

	[Token(Token = "0x601A561")]
	[Address(RVA = "0x32E9008", Offset = "0x32E9008", VA = "0x32E9008", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A562")]
	[Address(RVA = "0x3300B34", Offset = "0x3300B34", VA = "0x3300B34", Slot = "5")]
	public override bool IsTimeout(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x601A563")]
	[Address(RVA = "0x32E96D8", Offset = "0x32E96D8", VA = "0x32E96D8")]
	protected void ResetTimer(float time, float time_out = 5f)
	{
	}
}
