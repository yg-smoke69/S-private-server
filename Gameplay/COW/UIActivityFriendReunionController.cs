using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F5D")]
public class UIActivityFriendReunionController : UIActivityContentController, _Attribute
{
	[Token(Token = "0x400C50C")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityFriendReunionView m_View;

	[Token(Token = "0x400C50D")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C50E")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isFriendReunionDirty;

	[Token(Token = "0x400C50F")]
	[FieldOffset(Offset = "0x34")]
	private List<UIBaseController> m_FriendReunionControllers;

	[Token(Token = "0x400C510")]
	private const float REWARDBACKDARK = 0.4f;

	[Token(Token = "0x400C511")]
	private const float REWARDBACKLIGHT = 0.3f;

	[Token(Token = "0x6009B49")]
	[Address(RVA = "0x2FACF94", Offset = "0x2FACF94", VA = "0x2FACF94")]
	public UIActivityFriendReunionController()
	{
	}

	[Token(Token = "0x6009B4A")]
	[Address(RVA = "0x2FAD020", Offset = "0x2FAD020", VA = "0x2FAD020")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B4B")]
	[Address(RVA = "0x2FAD0C8", Offset = "0x2FAD0C8", VA = "0x2FAD0C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B4C")]
	[Address(RVA = "0x2FAD29C", Offset = "0x2FAD29C", VA = "0x2FAD29C", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009B4D")]
	[Address(RVA = "0x2FAD304", Offset = "0x2FAD304", VA = "0x2FAD304")]
	private void CreateEventDescList()
	{
	}

	[Token(Token = "0x6009B4E")]
	[Address(RVA = "0x2FAF88C", Offset = "0x2FAF88C", VA = "0x2FAF88C", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009B4F")]
	[Address(RVA = "0x2FAFA18", Offset = "0x2FAFA18", VA = "0x2FAFA18", Slot = "36")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009B50")]
	[Address(RVA = "0x2FAFAD8", Offset = "0x2FAFAD8", VA = "0x2FAFAD8", Slot = "37")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009B51")]
	[Address(RVA = "0x2FAFB6C", Offset = "0x2FAFB6C", VA = "0x2FAFB6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B52")]
	[Address(RVA = "0x2FAFB74", Offset = "0x2FAFB74", VA = "0x2FAFB74")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009B53")]
	[Address(RVA = "0x2FAFB7C", Offset = "0x2FAFB7C", VA = "0x2FAFB7C")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
