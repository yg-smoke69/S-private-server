using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003347")]
public class UIDetailTipsBtnItemController : UIBaseController
{
	[Token(Token = "0x401388C")]
	[FieldOffset(Offset = "0x28")]
	private UIDetailTipsBtnItemView m_View;

	[Token(Token = "0x401388D")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_Gopos;

	[Token(Token = "0x401388E")]
	[FieldOffset(Offset = "0x30")]
	private string m_SubGopos;

	[Token(Token = "0x401388F")]
	[FieldOffset(Offset = "0x34")]
	private uint m_DetailId;

	[Token(Token = "0x4013890")]
	[FieldOffset(Offset = "0x38")]
	private Action m_GoClickCallback;

	[Token(Token = "0x4013891")]
	[FieldOffset(Offset = "0x3C")]
	private int m_from;

	[Token(Token = "0x6015C84")]
	[Address(RVA = "0x2D82954", Offset = "0x2D82954", VA = "0x2D82954")]
	public UIDetailTipsBtnItemController()
	{
	}

	[Token(Token = "0x6015C85")]
	[Address(RVA = "0x2D829E0", Offset = "0x2D829E0", VA = "0x2D829E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015C86")]
	[Address(RVA = "0x2D82A88", Offset = "0x2D82A88", VA = "0x2D82A88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015C87")]
	[Address(RVA = "0x2D82BE4", Offset = "0x2D82BE4", VA = "0x2D82BE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015C88")]
	[Address(RVA = "0x2D82C48", Offset = "0x2D82C48", VA = "0x2D82C48")]
	public void SetData(string des, uint gopos, string subgopos, uint detailId, Action goClickCallback)
	{
	}

	[Token(Token = "0x6015C89")]
	[Address(RVA = "0x2D82E2C", Offset = "0x2D82E2C", VA = "0x2D82E2C")]
	public void SetData(string des, Action goClickCallback)
	{
	}

	[Token(Token = "0x6015C8A")]
	[Address(RVA = "0x2D830D8", Offset = "0x2D830D8", VA = "0x2D830D8")]
	private void OnGoClick()
	{
	}

	[Token(Token = "0x6015C8B")]
	[Address(RVA = "0x2D83318", Offset = "0x2D83318", VA = "0x2D83318")]
	private void OnCustomClick()
	{
	}

	[Token(Token = "0x6015C8C")]
	[Address(RVA = "0x2D83384", Offset = "0x2D83384", VA = "0x2D83384")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015C8D")]
	[Address(RVA = "0x2D8338C", Offset = "0x2D8338C", VA = "0x2D8338C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
