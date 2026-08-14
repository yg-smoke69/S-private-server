using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F54")]
public class UIActivityContentAnnouncementController : UIActivityContentController
{
	[Token(Token = "0x2001F55")]
	public class Data
	{
		[Token(Token = "0x400C4E5")]
		[FieldOffset(Offset = "0x8")]
		public string introduction;

		[Token(Token = "0x400C4E6")]
		[FieldOffset(Offset = "0xC")]
		public uint goPos;

		[Token(Token = "0x400C4E7")]
		[FieldOffset(Offset = "0x10")]
		public string subGoPos;

		[Token(Token = "0x400C4E8")]
		[FieldOffset(Offset = "0x14")]
		public bool prefersExternal;

		[Token(Token = "0x400C4E9")]
		[FieldOffset(Offset = "0x18")]
		public string image_url;

		[Token(Token = "0x6009B0A")]
		[Address(RVA = "0x2A0E018", Offset = "0x2A0E018", VA = "0x2A0E018")]
		public Data(string introduction, uint goPos, string subGoPos, bool prefersExternal, string image_url)
		{
		}
	}

	[Token(Token = "0x400C4E2")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityContentAnnouncementView m_View;

	[Token(Token = "0x400C4E3")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_SelectInfo;

	[Token(Token = "0x400C4E4")]
	[FieldOffset(Offset = "0x30")]
	private CommunityWebsiteData m_websiteData;

	[Token(Token = "0x6009AFD")]
	[Address(RVA = "0x2A0CFB4", Offset = "0x2A0CFB4", VA = "0x2A0CFB4")]
	public UIActivityContentAnnouncementController()
	{
	}

	[Token(Token = "0x6009AFE")]
	[Address(RVA = "0x2A0CFB8", Offset = "0x2A0CFB8", VA = "0x2A0CFB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009AFF")]
	[Address(RVA = "0x2A0D05C", Offset = "0x2A0D05C", VA = "0x2A0D05C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B00")]
	[Address(RVA = "0x2A0D800", Offset = "0x2A0D800", VA = "0x2A0D800", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009B01")]
	[Address(RVA = "0x2A0D864", Offset = "0x2A0D864", VA = "0x2A0D864", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009B02")]
	[Address(RVA = "0x2A0DB9C", Offset = "0x2A0DB9C", VA = "0x2A0DB9C")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x6009B03")]
	[Address(RVA = "0x2A0DD28", Offset = "0x2A0DD28", VA = "0x2A0DD28")]
	private void OpenCommunityWebsite(bool facebook = false, bool offical = false)
	{
	}

	[Token(Token = "0x6009B04")]
	[Address(RVA = "0x2A0D3AC", Offset = "0x2A0D3AC", VA = "0x2A0D3AC")]
	private CommunityWebsiteData GetCommunityWebsiteData()
	{
		return null;
	}

	[Token(Token = "0x6009B05")]
	[Address(RVA = "0x2A0DFEC", Offset = "0x2A0DFEC", VA = "0x2A0DFEC")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6009B06")]
	[Address(RVA = "0x2A0DFF8", Offset = "0x2A0DFF8", VA = "0x2A0DFF8")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x6009B07")]
	[Address(RVA = "0x2A0E004", Offset = "0x2A0E004", VA = "0x2A0E004")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B08")]
	[Address(RVA = "0x2A0E00C", Offset = "0x2A0E00C", VA = "0x2A0E00C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009B09")]
	[Address(RVA = "0x2A0E014", Offset = "0x2A0E014", VA = "0x2A0E014")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
