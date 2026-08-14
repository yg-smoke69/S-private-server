using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F74")]
public class UIActivityScrollViewItemController : UIActivityContentController
{
	[Token(Token = "0x400C57B")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityScrollViewItemView m_View;

	[Token(Token = "0x400C57C")]
	[FieldOffset(Offset = "0x2C")]
	private UIActivityScrollViewController.Data m_Data;

	[Token(Token = "0x6009BF4")]
	[Address(RVA = "0x2FC0344", Offset = "0x2FC0344", VA = "0x2FC0344")]
	public UIActivityScrollViewItemController()
	{
	}

	[Token(Token = "0x6009BF5")]
	[Address(RVA = "0x2FC034C", Offset = "0x2FC034C", VA = "0x2FC034C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009BF6")]
	[Address(RVA = "0x2FC03F0", Offset = "0x2FC03F0", VA = "0x2FC03F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BF7")]
	[Address(RVA = "0x2FC008C", Offset = "0x2FC008C", VA = "0x2FC008C")]
	public void SetData(UIActivityScrollViewController.Data data)
	{
	}

	[Token(Token = "0x6009BF8")]
	[Address(RVA = "0x2FC04AC", Offset = "0x2FC04AC", VA = "0x2FC04AC")]
	private void OnGoToClick()
	{
	}

	[Token(Token = "0x6009BF9")]
	[Address(RVA = "0x2FC026C", Offset = "0x2FC026C", VA = "0x2FC026C")]
	public void SetLine()
	{
	}

	[Token(Token = "0x6009BFA")]
	[Address(RVA = "0x2FC0614", Offset = "0x2FC0614", VA = "0x2FC0614")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
