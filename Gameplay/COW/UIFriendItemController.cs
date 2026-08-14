using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002621")]
public class UIFriendItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400EB77")]
	[FieldOffset(Offset = "0x38")]
	private UIFriendItemView m_View;

	[Token(Token = "0x400EB78")]
	[FieldOffset(Offset = "0x3C")]
	private FriendAccountInfo m_Data;

	[Token(Token = "0x400EB79")]
	[FieldOffset(Offset = "0x40")]
	private UIDragScrollView m_DragComponent;

	[Token(Token = "0x400EB7A")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider m_ItemCollider;

	[Token(Token = "0x400EB7B")]
	[FieldOffset(Offset = "0x48")]
	private EFriendTabType tabType;

	[Token(Token = "0x400EB7C")]
	[FieldOffset(Offset = "0x4C")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x400EB7D")]
	[FieldOffset(Offset = "0x50")]
	private string m_GiftCondition;

	[Token(Token = "0x400EB7E")]
	[FieldOffset(Offset = "0x54")]
	private uint m_friend_tag;

	[Token(Token = "0x400EB7F")]
	[FieldOffset(Offset = "0x58")]
	private bool m_HasPlayedAnim;

	[Token(Token = "0x1700115E")]
	public UIDragScrollView DragComponent
	{
		[Token(Token = "0x600E21D")]
		[Address(RVA = "0x24FF338", Offset = "0x24FF338", VA = "0x24FF338")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700115F")]
	public Vector2 ItemViewSize
	{
		[Token(Token = "0x600E21F")]
		[Address(RVA = "0x24FF4D8", Offset = "0x24FF4D8", VA = "0x24FF4D8")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x600E21C")]
	[Address(RVA = "0x24FF298", Offset = "0x24FF298", VA = "0x24FF298")]
	public UIFriendItemController()
	{
	}

	[Token(Token = "0x600E21E")]
	[Address(RVA = "0x24FF434", Offset = "0x24FF434", VA = "0x24FF434")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E220")]
	[Address(RVA = "0x24FF6E0", Offset = "0x24FF6E0", VA = "0x24FF6E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E221")]
	[Address(RVA = "0x24FE0A8", Offset = "0x24FE0A8", VA = "0x24FE0A8")]
	public void SetWidth(int width)
	{
	}

	[Token(Token = "0x600E222")]
	[Address(RVA = "0x24FFD7C", Offset = "0x24FFD7C", VA = "0x24FFD7C")]
	private void OnSendGiftBtnClick()
	{
	}

	[Token(Token = "0x600E223")]
	[Address(RVA = "0x250028C", Offset = "0x250028C", VA = "0x250028C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E224")]
	[Address(RVA = "0x25002FC", Offset = "0x25002FC", VA = "0x25002FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E225")]
	[Address(RVA = "0x2500438", Offset = "0x2500438", VA = "0x2500438", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600E226")]
	[Address(RVA = "0x2500CBC", Offset = "0x2500CBC", VA = "0x2500CBC")]
	public void SetData(FriendAccountInfo accountInfo)
	{
	}

	[Token(Token = "0x600E227")]
	[Address(RVA = "0x24FBA08", Offset = "0x24FBA08", VA = "0x24FBA08")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600E228")]
	[Address(RVA = "0x2504574", Offset = "0x2504574", VA = "0x2504574")]
	private void OnChatBtnClick()
	{
	}

	[Token(Token = "0x600E229")]
	[Address(RVA = "0x2504AF8", Offset = "0x2504AF8", VA = "0x2504AF8")]
	private void OnAddBtnClick()
	{
	}

	[Token(Token = "0x600E22A")]
	[Address(RVA = "0x2504FF4", Offset = "0x2504FF4", VA = "0x2504FF4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E22B")]
	[Address(RVA = "0x250538C", Offset = "0x250538C", VA = "0x250538C", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E22C")]
	[Address(RVA = "0x2505400", Offset = "0x2505400", VA = "0x2505400", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E22D")]
	[Address(RVA = "0x2505494", Offset = "0x2505494", VA = "0x2505494")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E22E")]
	[Address(RVA = "0x250549C", Offset = "0x250549C", VA = "0x250549C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E22F")]
	[Address(RVA = "0x25054A4", Offset = "0x25054A4", VA = "0x25054A4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E230")]
	[Address(RVA = "0x25054AC", Offset = "0x25054AC", VA = "0x25054AC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
