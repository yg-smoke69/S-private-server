using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003ED0")]
internal class AnimationConfigDataManager : SingletonModule<AnimationConfigDataManager>
{
	[Token(Token = "0x401A862")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<AnimationID, AnimationConfigData> m_AnimConfigDatas;

	[Token(Token = "0x401A863")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<long, AnimationBlendConfigData> m_AnimBlendConfigDatas;

	[Token(Token = "0x6019910")]
	[Address(RVA = "0x26B4C1C", Offset = "0x26B4C1C", VA = "0x26B4C1C")]
	public AnimationConfigDataManager()
	{
	}

	[Token(Token = "0x6019911")]
	[Address(RVA = "0x26B4D14", Offset = "0x26B4D14", VA = "0x26B4D14", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6019912")]
	[Address(RVA = "0x26B4DE8", Offset = "0x26B4DE8", VA = "0x26B4DE8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6019913")]
	[Address(RVA = "0x26B51E4", Offset = "0x26B51E4", VA = "0x26B51E4")]
	public AnimationBlendConfigData GetAnimBlendConfigData(AnimationID fadeOut, AnimationID fadeIn)
	{
		return null;
	}

	[Token(Token = "0x6019914")]
	[Address(RVA = "0x26B53C0", Offset = "0x26B53C0", VA = "0x26B53C0")]
	public AnimationConfigData GetAnimConfigData(int id)
	{
		return null;
	}
}
