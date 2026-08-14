using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026FB")]
internal class UIHudBuffTemplateController : UIBaseController
{
	[Token(Token = "0x400F0A4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBuffTemplateView m_View;

	[Token(Token = "0x400F0A5")]
	[FieldOffset(Offset = "0x2C")]
	public BountyPickupStatus BountyStatus;

	[Token(Token = "0x400F0A6")]
	[FieldOffset(Offset = "0x30")]
	private float m_TotalLife;

	[Token(Token = "0x400F0A7")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurrentLife;

	[Token(Token = "0x400F0A8")]
	[FieldOffset(Offset = "0x38")]
	private KNAJBCCEAHI _003CBuffBevTypeID_003Ek__BackingField;

	[Token(Token = "0x170011B3")]
	public KNAJBCCEAHI BuffBevTypeID
	{
		[Token(Token = "0x600EC9F")]
		[Address(RVA = "0x1EFC498", Offset = "0x1EFC498", VA = "0x1EFC498")]
		get
		{
			return default(KNAJBCCEAHI);
		}
		[Token(Token = "0x600ECA0")]
		[Address(RVA = "0x1EFC4A0", Offset = "0x1EFC4A0", VA = "0x1EFC4A0")]
		set
		{
		}
	}

	[Token(Token = "0x600EC9E")]
	[Address(RVA = "0x1EFC40C", Offset = "0x1EFC40C", VA = "0x1EFC40C")]
	public UIHudBuffTemplateController()
	{
	}

	[Token(Token = "0x600ECA1")]
	[Address(RVA = "0x1EFC4A8", Offset = "0x1EFC4A8", VA = "0x1EFC4A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ECA2")]
	[Address(RVA = "0x1EFC54C", Offset = "0x1EFC54C", VA = "0x1EFC54C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ECA3")]
	[Address(RVA = "0x1EFC790", Offset = "0x1EFC790", VA = "0x1EFC790")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x600ECA4")]
	[Address(RVA = "0x1EFC7E4", Offset = "0x1EFC7E4", VA = "0x1EFC7E4")]
	public void OnReInit()
	{
	}

	[Token(Token = "0x600ECA5")]
	[Address(RVA = "0x1EFC8EC", Offset = "0x1EFC8EC", VA = "0x1EFC8EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ECA6")]
	[Address(RVA = "0x1EFC950", Offset = "0x1EFC950", VA = "0x1EFC950")]
	public void SetUIData(CBIKNJDAGLO bevData)
	{
	}

	[Token(Token = "0x600ECA7")]
	[Address(RVA = "0x1EFCB7C", Offset = "0x1EFCB7C", VA = "0x1EFCB7C")]
	public void UpdateLifeTime(float life)
	{
	}

	[Token(Token = "0x600ECA8")]
	[Address(RVA = "0x1EFCBF0", Offset = "0x1EFCBF0", VA = "0x1EFCBF0")]
	private void UpdateCDProgress()
	{
	}

	[Token(Token = "0x600ECA9")]
	[Address(RVA = "0x1EFCDB8", Offset = "0x1EFCDB8", VA = "0x1EFCDB8")]
	private void Update()
	{
	}

	[Token(Token = "0x600ECAA")]
	[Address(RVA = "0x1EFCEC8", Offset = "0x1EFCEC8", VA = "0x1EFCEC8")]
	private void OnPress(GameObject go, bool value)
	{
	}

	[Token(Token = "0x600ECAB")]
	[Address(RVA = "0x1EFCF98", Offset = "0x1EFCF98", VA = "0x1EFCF98")]
	private void OnShowEnergyStoneBuffTutorial(object[] parma)
	{
	}

	[Token(Token = "0x600ECAC")]
	[Address(RVA = "0x1EFD0E4", Offset = "0x1EFD0E4", VA = "0x1EFD0E4")]
	private void OnShowMatchStartBuffTutorial(object[] parma)
	{
	}

	[Token(Token = "0x600ECAD")]
	[Address(RVA = "0x1EFD3B8", Offset = "0x1EFD3B8", VA = "0x1EFD3B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ECAE")]
	[Address(RVA = "0x1EFD3C0", Offset = "0x1EFD3C0", VA = "0x1EFD3C0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
