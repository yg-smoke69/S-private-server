using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200251F")]
public class UIChatWorldContainerController : UIChatBaseContainerController, _Attribute
{
	[Token(Token = "0x400E631")]
	[FieldOffset(Offset = "0x28")]
	private UIChatWorldContainerView m_View;

	[Token(Token = "0x400E632")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelChat m_Model;

	[Token(Token = "0x400E633")]
	[FieldOffset(Offset = "0x30")]
	private uint m_UpdateLiftTopCallID;

	[Token(Token = "0x400E634")]
	[FieldOffset(Offset = "0x34")]
	private uint m_HideLiftTopCallID;

	[Token(Token = "0x400E635")]
	[FieldOffset(Offset = "0x38")]
	private Queue<MessageInfo> m_LiftTopMessageList;

	[Token(Token = "0x600D7A4")]
	[Address(RVA = "0x20875D0", Offset = "0x20875D0", VA = "0x20875D0")]
	public UIChatWorldContainerController()
	{
	}

	[Token(Token = "0x600D7A5")]
	[Address(RVA = "0x208765C", Offset = "0x208765C", VA = "0x208765C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D7A6")]
	[Address(RVA = "0x2087700", Offset = "0x2087700", VA = "0x2087700", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D7A7")]
	[Address(RVA = "0x208793C", Offset = "0x208793C", VA = "0x208793C")]
	private void OnAddLiftTopMessage(object[] data)
	{
	}

	[Token(Token = "0x600D7A8")]
	[Address(RVA = "0x2087BAC", Offset = "0x2087BAC", VA = "0x2087BAC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D7A9")]
	[Address(RVA = "0x2087D8C", Offset = "0x2087D8C", VA = "0x2087D8C", Slot = "31")]
	public override GameObject GetContentNode()
	{
		return null;
	}

	[Token(Token = "0x600D7AA")]
	[Address(RVA = "0x2087DFC", Offset = "0x2087DFC", VA = "0x2087DFC", Slot = "32")]
	public override GameObject GetEmptyNode()
	{
		return null;
	}

	[Token(Token = "0x600D7AB")]
	[Address(RVA = "0x2087E6C", Offset = "0x2087E6C", VA = "0x2087E6C", Slot = "33")]
	public override UIScrollView GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x600D7AC")]
	[Address(RVA = "0x2087EDC", Offset = "0x2087EDC", VA = "0x2087EDC", Slot = "34")]
	public override void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D7AD")]
	[Address(RVA = "0x20881C0", Offset = "0x20881C0", VA = "0x20881C0", Slot = "35")]
	public override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D7AE")]
	[Address(RVA = "0x2088214", Offset = "0x2088214", VA = "0x2088214", Slot = "36")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D7AF")]
	[Address(RVA = "0x2087A44", Offset = "0x2087A44", VA = "0x2087A44")]
	private void AddLiftTopMessage(MessageInfo info)
	{
	}

	[Token(Token = "0x600D7B0")]
	[Address(RVA = "0x20883D4", Offset = "0x20883D4", VA = "0x20883D4")]
	private void ShowLiftTopMessage()
	{
	}

	[Token(Token = "0x600D7B1")]
	[Address(RVA = "0x2088710", Offset = "0x2088710", VA = "0x2088710", Slot = "37")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D7B2")]
	[Address(RVA = "0x20887A4", Offset = "0x20887A4", VA = "0x20887A4")]
	private void _003CShowLiftTopMessage_003Em__0()
	{
	}

	[Token(Token = "0x600D7B3")]
	[Address(RVA = "0x2088850", Offset = "0x2088850", VA = "0x2088850")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D7B4")]
	[Address(RVA = "0x2088858", Offset = "0x2088858", VA = "0x2088858")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D7B5")]
	[Address(RVA = "0x2088860", Offset = "0x2088860", VA = "0x2088860")]
	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
