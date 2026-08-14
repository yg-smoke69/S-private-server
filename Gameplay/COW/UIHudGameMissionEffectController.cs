using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002755")]
internal class UIHudGameMissionEffectController : UIBaseController
{
	[Token(Token = "0x400F2E9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGameMissionEffectView m_View;

	[Token(Token = "0x400F2EA")]
	[FieldOffset(Offset = "0x2C")]
	private GameObject m_Effect;

	[Token(Token = "0x400F2EB")]
	[FieldOffset(Offset = "0x30")]
	private ResourceID m_EffectRes;

	[Token(Token = "0x600F057")]
	[Address(RVA = "0x1887738", Offset = "0x1887738", VA = "0x1887738")]
	public UIHudGameMissionEffectController()
	{
	}

	[Token(Token = "0x600F058")]
	[Address(RVA = "0x1887804", Offset = "0x1887804", VA = "0x1887804")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F059")]
	[Address(RVA = "0x18878AC", Offset = "0x18878AC", VA = "0x18878AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F05A")]
	[Address(RVA = "0x1887968", Offset = "0x1887968", VA = "0x1887968")]
	public void SetGameMissionEffect(ResourceID effectRes)
	{
	}

	[Token(Token = "0x600F05B")]
	[Address(RVA = "0x1887E48", Offset = "0x1887E48", VA = "0x1887E48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
