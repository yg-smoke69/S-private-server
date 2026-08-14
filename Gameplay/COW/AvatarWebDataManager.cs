using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DAC")]
public class AvatarWebDataManager : SingletonModule<AvatarWebDataManager>
{
	[Token(Token = "0x4011888")]
	[FieldOffset(Offset = "0xC")]
	private List<AvatarWebData> m_Data;

	[Token(Token = "0x60131F5")]
	[Address(RVA = "0x236C910", Offset = "0x236C910", VA = "0x236C910")]
	public AvatarWebDataManager()
	{
	}

	[Token(Token = "0x60131F6")]
	[Address(RVA = "0x236C9D4", Offset = "0x236C9D4", VA = "0x236C9D4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60131F7")]
	[Address(RVA = "0x236CA94", Offset = "0x236CA94", VA = "0x236CA94", Slot = "6")]
	protected override void OnInit()
	{
	}
}
