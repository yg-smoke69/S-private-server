using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E67")]
public class AudioPlayInfo
{
	[Token(Token = "0x401A622")]
	[FieldOffset(Offset = "0x8")]
	public ResourceID ResID;

	[Token(Token = "0x401A623")]
	[FieldOffset(Offset = "0xC")]
	public string OwnedObjectName;

	[Token(Token = "0x401A624")]
	[FieldOffset(Offset = "0x10")]
	public EAudioDebugType DebugType;

	[Token(Token = "0x401A625")]
	[FieldOffset(Offset = "0x14")]
	public EAudioEngineType EngineType;

	[Token(Token = "0x401A626")]
	[FieldOffset(Offset = "0x18")]
	public float StartTimeStamp;

	[Token(Token = "0x401A627")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsRemoved;

	[Token(Token = "0x6019606")]
	[Address(RVA = "0x307863C", Offset = "0x307863C", VA = "0x307863C")]
	public AudioPlayInfo()
	{
	}
}
