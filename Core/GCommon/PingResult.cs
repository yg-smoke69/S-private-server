using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004068")]
public class PingResult : NetDetectionResult
{
	[Token(Token = "0x401B198")]
	[FieldOffset(Offset = "0xC")]
	public int average_delay;

	[Token(Token = "0x401B199")]
	[FieldOffset(Offset = "0x10")]
	public int loss_rate;

	[Token(Token = "0x601A364")]
	[Address(RVA = "0x2970390", Offset = "0x2970390", VA = "0x2970390")]
	public PingResult()
	{
	}
}
