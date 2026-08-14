using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004069")]
public class CDNResult : NetDetectionResult
{
	[Token(Token = "0x401B19A")]
	[FieldOffset(Offset = "0xC")]
	public float req_time;

	[Token(Token = "0x401B19B")]
	[FieldOffset(Offset = "0x10")]
	public long reponse_code;

	[Token(Token = "0x601A365")]
	[Address(RVA = "0x307E114", Offset = "0x307E114", VA = "0x307E114")]
	public CDNResult()
	{
	}
}
