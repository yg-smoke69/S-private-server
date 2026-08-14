using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F71")]
public class UIAcitivtyPreloginContentController : UIActivityContentController
{
	[Token(Token = "0x400C573")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityPreloginContentView m_View;

	[Token(Token = "0x400C574")]
	[FieldOffset(Offset = "0x2C")]
	private ActivityGroupDesc m_GroupDesc;

	[Token(Token = "0x400C575")]
	[FieldOffset(Offset = "0x30")]
	private List<ActivityPreloginDescription> m_AwardDescUIs;

	[Token(Token = "0x6009BE2")]
	[Address(RVA = "0x2A00964", Offset = "0x2A00964", VA = "0x2A00964")]
	public UIAcitivtyPreloginContentController()
	{
	}

	[Token(Token = "0x6009BE3")]
	[Address(RVA = "0x2A00A70", Offset = "0x2A00A70", VA = "0x2A00A70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009BE4")]
	[Address(RVA = "0x2A00B14", Offset = "0x2A00B14", VA = "0x2A00B14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BE5")]
	[Address(RVA = "0x2A00BD0", Offset = "0x2A00BD0", VA = "0x2A00BD0", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009BE6")]
	[Address(RVA = "0x2A00CC8", Offset = "0x2A00CC8", VA = "0x2A00CC8")]
	private void UpdateActivityInfo()
	{
	}

	[Token(Token = "0x6009BE7")]
	[Address(RVA = "0x2A00D1C", Offset = "0x2A00D1C", VA = "0x2A00D1C")]
	private void CreateEventDescList()
	{
	}

	[Token(Token = "0x6009BE8")]
	[Address(RVA = "0x2A00F8C", Offset = "0x2A00F8C", VA = "0x2A00F8C")]
	private ActivityPreloginDescription CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6009BE9")]
	[Address(RVA = "0x2A01150", Offset = "0x2A01150", VA = "0x2A01150", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009BEA")]
	[Address(RVA = "0x2A01358", Offset = "0x2A01358", VA = "0x2A01358")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009BEB")]
	[Address(RVA = "0x2A01360", Offset = "0x2A01360", VA = "0x2A01360")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009BEC")]
	[Address(RVA = "0x2A013C0", Offset = "0x2A013C0", VA = "0x2A013C0")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
