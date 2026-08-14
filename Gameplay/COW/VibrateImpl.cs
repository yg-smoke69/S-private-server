using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20003BF")]
public class VibrateImpl : _Attribute
{
	[Token(Token = "0x17000192")]
	public bool EnableVibrateFeature
	{
		[Token(Token = "0x600106C")]
		[Address(RVA = "0x21A033C", Offset = "0x21A033C", VA = "0x21A033C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600106B")]
	[Address(RVA = "0x21A0334", Offset = "0x21A0334", VA = "0x21A0334")]
	public VibrateImpl()
	{
	}
}
