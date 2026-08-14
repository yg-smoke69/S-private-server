using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F4B")]
public class UIActivityADContentController : UIActivityContentController
{
	[Token(Token = "0x2001F4C")]
	public class Data
	{
		[Token(Token = "0x400C4BA")]
		[FieldOffset(Offset = "0x8")]
		public uint id;

		[Token(Token = "0x400C4BB")]
		[FieldOffset(Offset = "0xC")]
		public uint groupId;

		[Token(Token = "0x400C4BC")]
		[FieldOffset(Offset = "0x10")]
		public string url;

		[Token(Token = "0x400C4BD")]
		[FieldOffset(Offset = "0x14")]
		public uint goPos;

		[Token(Token = "0x400C4BE")]
		[FieldOffset(Offset = "0x18")]
		public string subGoPos;

		[Token(Token = "0x400C4BF")]
		[FieldOffset(Offset = "0x1C")]
		public bool prefersExternal;

		[Token(Token = "0x400C4C0")]
		[FieldOffset(Offset = "0x1D")]
		public bool enableGotoButton;

		[Token(Token = "0x400C4C1")]
		[FieldOffset(Offset = "0x1E")]
		public bool isAnnouncement;

		[Token(Token = "0x6009AAB")]
		[Address(RVA = "0x2A03A0C", Offset = "0x2A03A0C", VA = "0x2A03A0C")]
		public Data()
		{
		}
	}

	[Token(Token = "0x400C4B7")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityADContentView m_View;

	[Token(Token = "0x400C4B8")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400C4B9")]
	[FieldOffset(Offset = "0x30")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x6009A9F")]
	[Address(RVA = "0x2A02900", Offset = "0x2A02900", VA = "0x2A02900")]
	public UIActivityADContentController()
	{
	}

	[Token(Token = "0x6009AA0")]
	[Address(RVA = "0x2A02904", Offset = "0x2A02904", VA = "0x2A02904")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009AA1")]
	[Address(RVA = "0x2A029A8", Offset = "0x2A029A8", VA = "0x2A029A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009AA2")]
	[Address(RVA = "0x2A02D8C", Offset = "0x2A02D8C", VA = "0x2A02D8C", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009AA3")]
	[Address(RVA = "0x2A031B8", Offset = "0x2A031B8", VA = "0x2A031B8")]
	private void OnGoToClick()
	{
	}

	[Token(Token = "0x6009AA4")]
	[Address(RVA = "0x2A03438", Offset = "0x2A03438", VA = "0x2A03438")]
	private void SendBannerClickLog(uint id)
	{
	}

	[Token(Token = "0x6009AA5")]
	[Address(RVA = "0x2A03644", Offset = "0x2A03644", VA = "0x2A03644", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009AA6")]
	[Address(RVA = "0x2A0372C", Offset = "0x2A0372C", VA = "0x2A0372C")]
	private void _003COnUIInit_003Em__0(GameObject e)
	{
	}

	[Token(Token = "0x6009AA7")]
	[Address(RVA = "0x2A03730", Offset = "0x2A03730", VA = "0x2A03730")]
	private void _003CSetData_003Em__1()
	{
	}

	[Token(Token = "0x6009AA8")]
	[Address(RVA = "0x2A039FC", Offset = "0x2A039FC", VA = "0x2A039FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009AA9")]
	[Address(RVA = "0x2A03A04", Offset = "0x2A03A04", VA = "0x2A03A04")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009AAA")]
	[Address(RVA = "0x2A03A08", Offset = "0x2A03A08", VA = "0x2A03A08")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
