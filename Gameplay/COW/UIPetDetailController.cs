using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A4F")]
public class UIPetDetailController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x401040A")]
	[FieldOffset(Offset = "0x28")]
	private UIMallDetailView m_View;

	[Token(Token = "0x401040B")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPet m_PetModel;

	[Token(Token = "0x60112E5")]
	[Address(RVA = "0x23F3404", Offset = "0x23F3404", VA = "0x23F3404")]
	public UIPetDetailController()
	{
	}

	[Token(Token = "0x60112E6")]
	[Address(RVA = "0x23F3488", Offset = "0x23F3488", VA = "0x23F3488")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112E7")]
	[Address(RVA = "0x23F352C", Offset = "0x23F352C", VA = "0x23F352C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60112E8")]
	[Address(RVA = "0x23F3694", Offset = "0x23F3694", VA = "0x23F3694", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60112E9")]
	[Address(RVA = "0x23F37C8", Offset = "0x23F37C8", VA = "0x23F37C8")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x60112EA")]
	[Address(RVA = "0x23F382C", Offset = "0x23F382C", VA = "0x23F382C", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60112EB")]
	[Address(RVA = "0x23F3924", Offset = "0x23F3924", VA = "0x23F3924", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60112EC")]
	[Address(RVA = "0x23F39A0", Offset = "0x23F39A0", VA = "0x23F39A0", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60112ED")]
	[Address(RVA = "0x23F3A94", Offset = "0x23F3A94", VA = "0x23F3A94", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60112EE")]
	[Address(RVA = "0x23F3B70", Offset = "0x23F3B70", VA = "0x23F3B70")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60112EF")]
	[Address(RVA = "0x23F3B78", Offset = "0x23F3B78", VA = "0x23F3B78")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
