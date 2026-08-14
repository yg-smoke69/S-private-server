using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027AA")]
internal class UIHudManualTipsController : UIBaseController
{
	[Token(Token = "0x400F4DF")]
	[FieldOffset(Offset = "0x28")]
	private UIHudManualTipsView m_View;

	[Token(Token = "0x400F4E0")]
	[FieldOffset(Offset = "0x2C")]
	private TweenAlpha m_FadeInAlpha;

	[Token(Token = "0x400F4E1")]
	[FieldOffset(Offset = "0x30")]
	private TweenAlpha m_FadeOutAlpha;

	[Token(Token = "0x400F4E2")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ShowDelayCallID;

	[Token(Token = "0x400F4E3")]
	[FieldOffset(Offset = "0x38")]
	private uint m_HideDelayCallID;

	[Token(Token = "0x400F4E4")]
	[FieldOffset(Offset = "0x3C")]
	private float m_ShowTime;

	[Token(Token = "0x600F4B8")]
	[Address(RVA = "0xFF8DE4", Offset = "0xFF8DE4", VA = "0xFF8DE4")]
	public UIHudManualTipsController()
	{
	}

	[Token(Token = "0x600F4B9")]
	[Address(RVA = "0xFF8E74", Offset = "0xFF8E74", VA = "0xFF8E74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F4BA")]
	[Address(RVA = "0xFF8F18", Offset = "0xFF8F18", VA = "0xFF8F18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F4BB")]
	[Address(RVA = "0xFF90B8", Offset = "0xFF90B8", VA = "0xFF90B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F4BC")]
	[Address(RVA = "0xFF92F8", Offset = "0xFF92F8", VA = "0xFF92F8")]
	private void ShowTips()
	{
	}

	[Token(Token = "0x600F4BD")]
	[Address(RVA = "0xFF94D8", Offset = "0xFF94D8", VA = "0xFF94D8")]
	private void HideTips()
	{
	}

	[Token(Token = "0x600F4BE")]
	[Address(RVA = "0xFF9580", Offset = "0xFF9580", VA = "0xFF9580")]
	public void SetData(string content)
	{
	}

	[Token(Token = "0x600F4BF")]
	[Address(RVA = "0xFF9124", Offset = "0xFF9124", VA = "0xFF9124")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600F4C0")]
	[Address(RVA = "0xFF9884", Offset = "0xFF9884", VA = "0xFF9884")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F4C1")]
	[Address(RVA = "0xFF988C", Offset = "0xFF988C", VA = "0xFF988C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
