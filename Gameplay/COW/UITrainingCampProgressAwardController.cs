using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B7D")]
public class UITrainingCampProgressAwardController : UIBaseController
{
	[Token(Token = "0x4010A63")]
	[FieldOffset(Offset = "0x28")]
	private UITrainingCampProgressAwardView m_View;

	[Token(Token = "0x4010A64")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_Rank;

	[Token(Token = "0x4010A65")]
	[FieldOffset(Offset = "0x30")]
	private uint m_Milestone;

	[Token(Token = "0x4010A66")]
	[FieldOffset(Offset = "0x34")]
	private UIModelChummy.TrainingCampAwardStatus m_Status;

	[Token(Token = "0x4010A67")]
	[FieldOffset(Offset = "0x38")]
	private List<BaseItemInfo> m_AwardList;

	[Token(Token = "0x4010A68")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A69")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170012EE")]
	public uint Rank
	{
		[Token(Token = "0x6011F68")]
		[Address(RVA = "0x1C1EDDC", Offset = "0x1C1EDDC", VA = "0x1C1EDDC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170012EF")]
	public uint Milestone
	{
		[Token(Token = "0x6011F69")]
		[Address(RVA = "0x1C1EE34", Offset = "0x1C1EE34", VA = "0x1C1EE34")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6011F63")]
	[Address(RVA = "0x1C1E618", Offset = "0x1C1E618", VA = "0x1C1E618")]
	public UITrainingCampProgressAwardController()
	{
	}

	[Token(Token = "0x6011F64")]
	[Address(RVA = "0x1C1E69C", Offset = "0x1C1E69C", VA = "0x1C1E69C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F65")]
	[Address(RVA = "0x1C1E740", Offset = "0x1C1E740", VA = "0x1C1E740", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F66")]
	[Address(RVA = "0x1C1EA74", Offset = "0x1C1EA74", VA = "0x1C1EA74")]
	public void SetHorizontalPos(bool isHorizontal = true)
	{
	}

	[Token(Token = "0x6011F67")]
	[Address(RVA = "0x1C1EBB0", Offset = "0x1C1EBB0", VA = "0x1C1EBB0")]
	public void SetData(uint rank, uint milestone)
	{
	}

	[Token(Token = "0x6011F6A")]
	[Address(RVA = "0x1C1E914", Offset = "0x1C1E914", VA = "0x1C1E914")]
	private void InitView()
	{
	}

	[Token(Token = "0x6011F6B")]
	[Address(RVA = "0x1C1EE8C", Offset = "0x1C1EE8C", VA = "0x1C1EE8C")]
	public void SetAwardStatus(UIModelChummy.TrainingCampAwardStatus status, int cnt = 0)
	{
	}

	[Token(Token = "0x6011F6C")]
	[Address(RVA = "0x1C1F0D8", Offset = "0x1C1F0D8", VA = "0x1C1F0D8")]
	private void OnClickAwardBtn()
	{
	}

	[Token(Token = "0x6011F6D")]
	[Address(RVA = "0x1C1F330", Offset = "0x1C1F330", VA = "0x1C1F330")]
	private static BaseItemInfo _003CSetData_003Em__0(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x6011F6E")]
	[Address(RVA = "0x1C1F3B4", Offset = "0x1C1F3B4", VA = "0x1C1F3B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
