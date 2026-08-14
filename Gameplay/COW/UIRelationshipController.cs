using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002AC1")]
internal class UIRelationshipController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002AC2")]
	public enum CtrlType
	{
		[Token(Token = "0x40106CB")]
		NONE,
		[Token(Token = "0x40106CC")]
		CloseFriend,
		[Token(Token = "0x40106CD")]
		TrainingCamp
	}

	[Token(Token = "0x40106C4")]
	[FieldOffset(Offset = "0x28")]
	private UIRelationShipView m_View;

	[Token(Token = "0x40106C5")]
	[FieldOffset(Offset = "0x2C")]
	private UICloseFriendController m_CloseFriendController;

	[Token(Token = "0x40106C6")]
	[FieldOffset(Offset = "0x30")]
	private UITrainingCampController m_TrainingCampController;

	[Token(Token = "0x40106C7")]
	[FieldOffset(Offset = "0x34")]
	private EFriend.RelationType m_CurrentType;

	[Token(Token = "0x40106C8")]
	[FieldOffset(Offset = "0x38")]
	private CtrlType m_CtrlType;

	[Token(Token = "0x40106C9")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelRelationShip m_Model;

	[Token(Token = "0x170012D6")]
	public CtrlType CurCtrlType
	{
		[Token(Token = "0x6011831")]
		[Address(RVA = "0x1E4712C", Offset = "0x1E4712C", VA = "0x1E4712C")]
		get
		{
			return default(CtrlType);
		}
		[Token(Token = "0x6011832")]
		[Address(RVA = "0x1E47184", Offset = "0x1E47184", VA = "0x1E47184")]
		set
		{
		}
	}

	[Token(Token = "0x6011830")]
	[Address(RVA = "0x1E470A8", Offset = "0x1E470A8", VA = "0x1E470A8")]
	public UIRelationshipController()
	{
	}

	[Token(Token = "0x6011833")]
	[Address(RVA = "0x1E471E4", Offset = "0x1E471E4", VA = "0x1E471E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011834")]
	[Address(RVA = "0x1E47288", Offset = "0x1E47288", VA = "0x1E47288", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011835")]
	[Address(RVA = "0x1E472EC", Offset = "0x1E472EC", VA = "0x1E472EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011836")]
	[Address(RVA = "0x1E4742C", Offset = "0x1E4742C", VA = "0x1E4742C", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6011837")]
	[Address(RVA = "0x1E47654", Offset = "0x1E47654", VA = "0x1E47654", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6011838")]
	[Address(RVA = "0x1E47878", Offset = "0x1E47878", VA = "0x1E47878")]
	public void ShowContentByCurrentRelationship(EFriend.RelationType currentType)
	{
	}

	[Token(Token = "0x6011839")]
	[Address(RVA = "0x1E47CD4", Offset = "0x1E47CD4", VA = "0x1E47CD4")]
	public void ShowTrainingCampContent()
	{
	}

	[Token(Token = "0x601183A")]
	[Address(RVA = "0x1E47EA8", Offset = "0x1E47EA8", VA = "0x1E47EA8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601183B")]
	[Address(RVA = "0x1E47F8C", Offset = "0x1E47F8C", VA = "0x1E47F8C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601183C")]
	[Address(RVA = "0x1E47B60", Offset = "0x1E47B60", VA = "0x1E47B60")]
	private void InitControllers()
	{
	}

	[Token(Token = "0x601183D")]
	[Address(RVA = "0x1E48020", Offset = "0x1E48020", VA = "0x1E48020", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x601183E")]
	[Address(RVA = "0x1E48128", Offset = "0x1E48128", VA = "0x1E48128")]
	public void TryHideTrainingCampPreview()
	{
	}

	[Token(Token = "0x601183F")]
	[Address(RVA = "0x1E4822C", Offset = "0x1E4822C", VA = "0x1E4822C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6011840")]
	[Address(RVA = "0x1E48234", Offset = "0x1E48234", VA = "0x1E48234")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011841")]
	[Address(RVA = "0x1E4823C", Offset = "0x1E4823C", VA = "0x1E4823C")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6011842")]
	[Address(RVA = "0x1E48244", Offset = "0x1E48244", VA = "0x1E48244")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x6011843")]
	[Address(RVA = "0x1E4824C", Offset = "0x1E4824C", VA = "0x1E4824C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
