using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using proto;

namespace COW;

[Serializable]
[Token(Token = "0x2001EEC")]
internal class UIDigitaluniverseBRoleDoorDialogController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001EED")]
	private enum StoryContentType
	{
		[Token(Token = "0x400C2D5")]
		None,
		[Token(Token = "0x400C2D6")]
		NoOptionsDialog,
		[Token(Token = "0x400C2D7")]
		OptionsDialog
	}

	[Token(Token = "0x400C2C1")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBRoleDoorDialogView m_View;

	[Token(Token = "0x400C2C2")]
	private const uint MAXROLECOUNT = 5u;

	[Token(Token = "0x400C2C3")]
	private const uint MAXLABELSELECTCOUNT = 3u;

	[Token(Token = "0x400C2C4")]
	[FieldOffset(Offset = "0x74")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C2C5")]
	[FieldOffset(Offset = "0x78")]
	private UIModelActivity m_ModelAactivity;

	[Token(Token = "0x400C2C6")]
	[FieldOffset(Offset = "0x7C")]
	private List<uint> m_ListSkipStoryDialog;

	[Token(Token = "0x400C2C7")]
	[FieldOffset(Offset = "0x80")]
	private List<SkeletonAnimation> m_ListRole;

	[Token(Token = "0x400C2C8")]
	[FieldOffset(Offset = "0x84")]
	private List<UIButton> m_ListButtonStorySelect;

	[Token(Token = "0x400C2C9")]
	[FieldOffset(Offset = "0x88")]
	private List<UILabel> m_ListLabelStroySelect;

	[Token(Token = "0x400C2CA")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_storyId;

	[Token(Token = "0x400C2CB")]
	[FieldOffset(Offset = "0x90")]
	private List<string> m_ListRoleName;

	[Token(Token = "0x400C2CC")]
	[FieldOffset(Offset = "0x94")]
	private List<Transform> m_LeftRolePos;

	[Token(Token = "0x400C2CD")]
	[FieldOffset(Offset = "0x98")]
	private List<Transform> m_RightRolePos;

	[Token(Token = "0x400C2CE")]
	private const string ANIMATION_IDLE = "_Idle";

	[Token(Token = "0x400C2CF")]
	private const string ANIMATION_TALK = "_Talk";

	[Token(Token = "0x400C2D0")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_SkipStoryDialogId1;

	[Token(Token = "0x400C2D1")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_SkipStoryDialogId2;

	[Token(Token = "0x400C2D2")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_SkipStoryDialogId3;

	[Token(Token = "0x400C2D3")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_StoryGroupId;

	[Token(Token = "0x6009707")]
	[Address(RVA = "0x2F05AE0", Offset = "0x2F05AE0", VA = "0x2F05AE0")]
	public UIDigitaluniverseBRoleDoorDialogController()
	{
	}

	[Token(Token = "0x6009708")]
	[Address(RVA = "0x2F05AFC", Offset = "0x2F05AFC", VA = "0x2F05AFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009709")]
	[Address(RVA = "0x2F05BA4", Offset = "0x2F05BA4", VA = "0x2F05BA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600970A")]
	[Address(RVA = "0x2F06078", Offset = "0x2F06078", VA = "0x2F06078", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600970B")]
	[Address(RVA = "0x2F08454", Offset = "0x2F08454", VA = "0x2F08454", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x600970C")]
	[Address(RVA = "0x2F084AC", Offset = "0x2F084AC", VA = "0x2F084AC", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600970D")]
	[Address(RVA = "0x2F08504", Offset = "0x2F08504", VA = "0x2F08504", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600970E")]
	[Address(RVA = "0x2F06970", Offset = "0x2F06970", VA = "0x2F06970")]
	private void RefreshPlotView()
	{
	}

	[Token(Token = "0x600970F")]
	[Address(RVA = "0x2F08568", Offset = "0x2F08568", VA = "0x2F08568")]
	private void OnClickBtnSkipStoryDialog(int nextStoryId)
	{
	}

	[Token(Token = "0x6009710")]
	[Address(RVA = "0x2F08790", Offset = "0x2F08790", VA = "0x2F08790")]
	private void OnClickBtnNextDialog()
	{
	}

	[Token(Token = "0x6009711")]
	[Address(RVA = "0x2F08854", Offset = "0x2F08854", VA = "0x2F08854")]
	private void OnClickBtnSkip()
	{
	}

	[Token(Token = "0x6009712")]
	[Address(RVA = "0x2F08914", Offset = "0x2F08914", VA = "0x2F08914", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009713")]
	[Address(RVA = "0x2F089A8", Offset = "0x2F089A8", VA = "0x2F089A8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009714")]
	[Address(RVA = "0x2F09074", Offset = "0x2F09074", VA = "0x2F09074")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6009715")]
	[Address(RVA = "0x2F0907C", Offset = "0x2F0907C", VA = "0x2F0907C")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x6009716")]
	[Address(RVA = "0x2F09084", Offset = "0x2F09084", VA = "0x2F09084")]
	private void _003COnUIInit_003Em__2()
	{
	}

	[Token(Token = "0x6009717")]
	[Address(RVA = "0x2F0908C", Offset = "0x2F0908C", VA = "0x2F0908C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009718")]
	[Address(RVA = "0x2F09094", Offset = "0x2F09094", VA = "0x2F09094")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009719")]
	[Address(RVA = "0x2F0909C", Offset = "0x2F0909C", VA = "0x2F0909C")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x600971A")]
	[Address(RVA = "0x2F090A4", Offset = "0x2F090A4", VA = "0x2F090A4")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600971B")]
	[Address(RVA = "0x2F090AC", Offset = "0x2F090AC", VA = "0x2F090AC")]
	public new bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}
}
