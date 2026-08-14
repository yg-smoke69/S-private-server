using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F72")]
public class UIActivityScrollViewController : UIActivityContentController
{
	[Token(Token = "0x2001F73")]
	public class Data
	{
		[Token(Token = "0x400C577")]
		[FieldOffset(Offset = "0x8")]
		public uint goPos;

		[Token(Token = "0x400C578")]
		[FieldOffset(Offset = "0xC")]
		public string subGoPos;

		[Token(Token = "0x400C579")]
		[FieldOffset(Offset = "0x10")]
		public string image_url;

		[Token(Token = "0x400C57A")]
		[FieldOffset(Offset = "0x14")]
		public bool prefersExternal;

		[Token(Token = "0x6009BF3")]
		[Address(RVA = "0x2FC030C", Offset = "0x2FC030C", VA = "0x2FC030C")]
		public Data(uint goPos, string subGoPos, string image_url, bool prefersExternal)
		{
		}
	}

	[Token(Token = "0x400C576")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityScrollViewView m_View;

	[Token(Token = "0x6009BED")]
	[Address(RVA = "0x2FBFC1C", Offset = "0x2FBFC1C", VA = "0x2FBFC1C")]
	public UIActivityScrollViewController()
	{
	}

	[Token(Token = "0x6009BEE")]
	[Address(RVA = "0x2FBFC24", Offset = "0x2FBFC24", VA = "0x2FBFC24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009BEF")]
	[Address(RVA = "0x2FBFCC8", Offset = "0x2FBFCC8", VA = "0x2FBFCC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BF0")]
	[Address(RVA = "0x2FBFD84", Offset = "0x2FBFD84", VA = "0x2FBFD84", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009BF1")]
	[Address(RVA = "0x2FC02FC", Offset = "0x2FC02FC", VA = "0x2FC02FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009BF2")]
	[Address(RVA = "0x2FC0304", Offset = "0x2FC0304", VA = "0x2FC0304")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
