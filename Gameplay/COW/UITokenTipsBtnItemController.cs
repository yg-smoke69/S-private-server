using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200336D")]
public class UITokenTipsBtnItemController : UIBaseController
{
	[Token(Token = "0x4013955")]
	[FieldOffset(Offset = "0x28")]
	private UITokenTipsBtnItemView m_View;

	[Token(Token = "0x4013956")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_Gopos;

	[Token(Token = "0x4013957")]
	[FieldOffset(Offset = "0x30")]
	private string m_SubGopos;

	[Token(Token = "0x4013958")]
	[FieldOffset(Offset = "0x34")]
	private uint m_TokenId;

	[Token(Token = "0x6015DE3")]
	[Address(RVA = "0x201E93C", Offset = "0x201E93C", VA = "0x201E93C")]
	public UITokenTipsBtnItemController()
	{
	}

	[Token(Token = "0x6015DE4")]
	[Address(RVA = "0x201E9C0", Offset = "0x201E9C0", VA = "0x201E9C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015DE5")]
	[Address(RVA = "0x201EA64", Offset = "0x201EA64", VA = "0x201EA64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015DE6")]
	[Address(RVA = "0x201EBC0", Offset = "0x201EBC0", VA = "0x201EBC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015DE7")]
	[Address(RVA = "0x201EC24", Offset = "0x201EC24", VA = "0x201EC24")]
	public void SetData(string des, uint gopos, string subgopos, uint tokenId)
	{
	}

	[Token(Token = "0x6015DE8")]
	[Address(RVA = "0x201EDB8", Offset = "0x201EDB8", VA = "0x201EDB8")]
	private void OnGoClick()
	{
	}

	[Token(Token = "0x6015DE9")]
	[Address(RVA = "0x201EFB8", Offset = "0x201EFB8", VA = "0x201EFB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015DEA")]
	[Address(RVA = "0x201EFC0", Offset = "0x201EFC0", VA = "0x201EFC0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
