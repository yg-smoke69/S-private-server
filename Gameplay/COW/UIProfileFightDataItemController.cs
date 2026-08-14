using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A9C")]
public class UIProfileFightDataItemController : UIBaseController
{
	[Token(Token = "0x2002A9D")]
	private sealed class _003CStartPlayAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40105F6")]
		[FieldOffset(Offset = "0x8")]
		internal List<GameObject> _003Cm_currgameobj_003E__0;

		[Token(Token = "0x40105F7")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x40105F8")]
		[FieldOffset(Offset = "0x10")]
		internal Animation _003Ccomp_003E__2;

		[Token(Token = "0x40105F9")]
		[FieldOffset(Offset = "0x14")]
		internal UIProfileFightDataItemController _0024this;

		[Token(Token = "0x40105FA")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40105FB")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x40105FC")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x170012D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011697")]
			[Address(RVA = "0x16E5390", Offset = "0x16E5390", VA = "0x16E5390", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011698")]
			[Address(RVA = "0x16E5398", Offset = "0x16E5398", VA = "0x16E5398", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011695")]
		[Address(RVA = "0x16DD574", Offset = "0x16DD574", VA = "0x16DD574")]
		public _003CStartPlayAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011696")]
		[Address(RVA = "0x16E4E6C", Offset = "0x16E4E6C", VA = "0x16E4E6C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6011699")]
		[Address(RVA = "0x16E53A0", Offset = "0x16E53A0", VA = "0x16E53A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601169A")]
		[Address(RVA = "0x16E53B4", Offset = "0x16E53B4", VA = "0x16E53B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40105D3")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileFightDataItemView m_View;

	[Token(Token = "0x40105D4")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3[] m_5DMapMeshVetex;

	[Token(Token = "0x40105D5")]
	[FieldOffset(Offset = "0x30")]
	private float[] m_NormalizedValue;

	[Token(Token = "0x40105D6")]
	[FieldOffset(Offset = "0x34")]
	private float[] m_OriginalValue;

	[Token(Token = "0x40105D7")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> VFXObjectList;

	[Token(Token = "0x40105D8")]
	[FieldOffset(Offset = "0x3C")]
	private List<UILabel> VfxLabelList;

	[Token(Token = "0x40105D9")]
	[FieldOffset(Offset = "0x40")]
	private List<UISprite> VfxSpriteList;

	[Token(Token = "0x40105DA")]
	[FieldOffset(Offset = "0x44")]
	private List<GameObject> VFXObjectList2;

	[Token(Token = "0x40105DB")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> VFXObjectList3;

	[Token(Token = "0x40105DC")]
	[FieldOffset(Offset = "0x4C")]
	private List<Transform> VFXTransformList;

	[Token(Token = "0x40105DD")]
	private const int m_5DMapLength = 59;

	[Token(Token = "0x40105DE")]
	[FieldOffset(Offset = "0x50")]
	private Vector3[] m_3DMapMeshVetex;

	[Token(Token = "0x40105DF")]
	[FieldOffset(Offset = "0x54")]
	private float[] m_3DNormalizedValue;

	[Token(Token = "0x40105E0")]
	[FieldOffset(Offset = "0x58")]
	private float[] m_3DOriginalValue;

	[Token(Token = "0x40105E1")]
	[FieldOffset(Offset = "0x5C")]
	private List<GameObject> CSVFXObjectList;

	[Token(Token = "0x40105E2")]
	[FieldOffset(Offset = "0x60")]
	private List<GameObject> CSVFXObjectList2;

	[Token(Token = "0x40105E3")]
	[FieldOffset(Offset = "0x64")]
	private List<GameObject> CSVFXObjectList3;

	[Token(Token = "0x40105E4")]
	[FieldOffset(Offset = "0x68")]
	private List<Transform> CSVFXTransformList;

	[Token(Token = "0x40105E5")]
	private const int m_3DMapLength = 59;

	[Token(Token = "0x40105E6")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 m_MapCenterOffset;

	[Token(Token = "0x40105E7")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_CanStartDraw5DMap;

	[Token(Token = "0x40105E8")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_CanStartDraw3Dmap;

	[Token(Token = "0x40105E9")]
	[FieldOffset(Offset = "0x70")]
	private uint m_type;

	[Token(Token = "0x40105EA")]
	[FieldOffset(Offset = "0x74")]
	private EModeType m_ModeType;

	[Token(Token = "0x40105EB")]
	[FieldOffset(Offset = "0x78")]
	private uint m_CurrentFightMode;

	[Token(Token = "0x40105EC")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_DetailDataPanelOpen;

	[Token(Token = "0x40105ED")]
	[FieldOffset(Offset = "0x80")]
	private uint m_DisbleCall;

	[Token(Token = "0x40105EE")]
	[FieldOffset(Offset = "0x84")]
	private uint m_DelayCallID;

	[Token(Token = "0x40105EF")]
	[FieldOffset(Offset = "0x88")]
	private uint m_DelayArrowId;

	[Token(Token = "0x40105F0")]
	[FieldOffset(Offset = "0x8C")]
	private UIProfileMiniRankInfoController m_MiniRankInfoCtrl;

	[Token(Token = "0x40105F1")]
	[FieldOffset(Offset = "0x90")]
	private List<GameObject> m_ShowInfoList;

	[Token(Token = "0x40105F2")]
	[FieldOffset(Offset = "0x94")]
	private bool m_firsttimecommon;

	[Token(Token = "0x40105F3")]
	[FieldOffset(Offset = "0x95")]
	private bool m_firsttimecs;

	[Token(Token = "0x40105F4")]
	[FieldOffset(Offset = "0x98")]
	private List<string> m_VfxLabelList;

	[Token(Token = "0x40105F5")]
	[FieldOffset(Offset = "0x9C")]
	private List<string> m_CSVfxLabelList;

	[Token(Token = "0x6011667")]
	[Address(RVA = "0x16D6CA8", Offset = "0x16D6CA8", VA = "0x16D6CA8")]
	public UIProfileFightDataItemController()
	{
	}

	[Token(Token = "0x6011668")]
	[Address(RVA = "0x16D71BC", Offset = "0x16D71BC", VA = "0x16D71BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011669")]
	[Address(RVA = "0x16D7260", Offset = "0x16D7260", VA = "0x16D7260", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601166A")]
	[Address(RVA = "0x16D8D24", Offset = "0x16D8D24", VA = "0x16D8D24")]
	public void InitVfxList2Label()
	{
	}

	[Token(Token = "0x601166B")]
	[Address(RVA = "0x16D9304", Offset = "0x16D9304", VA = "0x16D9304")]
	private void InitVfxState()
	{
	}

	[Token(Token = "0x601166C")]
	[Address(RVA = "0x16D958C", Offset = "0x16D958C", VA = "0x16D958C")]
	private void InitCsVfxState()
	{
	}

	[Token(Token = "0x601166D")]
	[Address(RVA = "0x16D9814", Offset = "0x16D9814", VA = "0x16D9814")]
	private void CommonCallback()
	{
	}

	[Token(Token = "0x601166E")]
	[Address(RVA = "0x16D9F80", Offset = "0x16D9F80", VA = "0x16D9F80")]
	public void PlayCommonVfx()
	{
	}

	[Token(Token = "0x601166F")]
	[Address(RVA = "0x16DA16C", Offset = "0x16DA16C", VA = "0x16DA16C")]
	private void CSCallback()
	{
	}

	[Token(Token = "0x6011670")]
	[Address(RVA = "0x16DA8D8", Offset = "0x16DA8D8", VA = "0x16DA8D8")]
	public void PlayCsVfx()
	{
	}

	[Token(Token = "0x6011671")]
	[Address(RVA = "0x16DAAC4", Offset = "0x16DAAC4", VA = "0x16DAAC4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011672")]
	[Address(RVA = "0x16DAEF8", Offset = "0x16DAEF8", VA = "0x16DAEF8")]
	private void OnDisableBtn(object[] data)
	{
	}

	[Token(Token = "0x6011673")]
	[Address(RVA = "0x16DB174", Offset = "0x16DB174", VA = "0x16DB174")]
	private void OnDetailBtnClick()
	{
	}

	[Token(Token = "0x6011674")]
	[Address(RVA = "0x16DD054", Offset = "0x16DD054", VA = "0x16DD054")]
	public void SetModeType(EModeType modeType)
	{
	}

	[Token(Token = "0x6011675")]
	[Address(RVA = "0x16DBC08", Offset = "0x16DBC08", VA = "0x16DBC08")]
	public void RefreshOneItemShowUI(uint type)
	{
	}

	[Token(Token = "0x6011676")]
	[Address(RVA = "0x16DD4A8", Offset = "0x16DD4A8", VA = "0x16DD4A8")]
	private IEnumerator StartPlayAnim()
	{
		return null;
	}

	[Token(Token = "0x6011677")]
	[Address(RVA = "0x16DD57C", Offset = "0x16DD57C", VA = "0x16DD57C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6011678")]
	[Address(RVA = "0x16DD204", Offset = "0x16DD204", VA = "0x16DD204")]
	private void RefreshTopLabel(int num)
	{
	}

	[Token(Token = "0x6011679")]
	[Address(RVA = "0x16DD5D0", Offset = "0x16DD5D0", VA = "0x16DD5D0")]
	public void HideDetailPanel()
	{
	}

	[Token(Token = "0x601167A")]
	[Address(RVA = "0x16DD660", Offset = "0x16DD660", VA = "0x16DD660")]
	public void ShowDetailPanel()
	{
	}

	[Token(Token = "0x601167B")]
	[Address(RVA = "0x16DBA1C", Offset = "0x16DBA1C", VA = "0x16DBA1C")]
	public void RefreshProfileFightDataItemUI(uint type, PersonalRecordData data)
	{
	}

	[Token(Token = "0x601167C")]
	[Address(RVA = "0x16DE7F8", Offset = "0x16DE7F8", VA = "0x16DE7F8")]
	public void SetCommonModeUI()
	{
	}

	[Token(Token = "0x601167D")]
	[Address(RVA = "0x16DE8C0", Offset = "0x16DE8C0", VA = "0x16DE8C0")]
	public void DisableVFx()
	{
	}

	[Token(Token = "0x601167E")]
	[Address(RVA = "0x16DEA54", Offset = "0x16DEA54", VA = "0x16DEA54")]
	public void RefreshVfxState()
	{
	}

	[Token(Token = "0x601167F")]
	[Address(RVA = "0x16DF034", Offset = "0x16DF034", VA = "0x16DF034")]
	private void Show5DimensionalMap(float[] fieldDatas, string[] fieldNames)
	{
	}

	[Token(Token = "0x6011680")]
	[Address(RVA = "0x16DD6F0", Offset = "0x16DD6F0", VA = "0x16DD6F0")]
	private void ShowProfileFightDataItemUI(PersonalRecordData data, uint type)
	{
	}

	[Token(Token = "0x6011681")]
	[Address(RVA = "0x16E005C", Offset = "0x16E005C", VA = "0x16E005C")]
	private Vector3 SetVertexPos(int index, float normalizedValue)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6011682")]
	[Address(RVA = "0x16E02F8", Offset = "0x16E02F8", VA = "0x16E02F8")]
	private Vector3 SetCSVertexPos(int index, float normalizedValue)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6011683")]
	[Address(RVA = "0x16E0594", Offset = "0x16E0594", VA = "0x16E0594")]
	public void RefreshPeriodicRankingData(CSPlayerPeriodicRankingInfoRes info)
	{
	}

	[Token(Token = "0x6011684")]
	[Address(RVA = "0x16E2034", Offset = "0x16E2034", VA = "0x16E2034")]
	public void RefreshCSRankingData(CSLadderSeasonStatsInfo info)
	{
	}

	[Token(Token = "0x6011685")]
	[Address(RVA = "0x16E2E34", Offset = "0x16E2E34", VA = "0x16E2E34")]
	private void Set3DVertexData(float csleader, float cssupport, float cskill, float csdamage, float csparticipation)
	{
	}

	[Token(Token = "0x6011686")]
	[Address(RVA = "0x16E3B10", Offset = "0x16E3B10", VA = "0x16E3B10")]
	private void DrawFiveDMap()
	{
	}

	[Token(Token = "0x6011687")]
	[Address(RVA = "0x16E42F0", Offset = "0x16E42F0", VA = "0x16E42F0")]
	private void DrawThreeDMap()
	{
	}

	[Token(Token = "0x6011688")]
	[Address(RVA = "0x16E3F90", Offset = "0x16E3F90", VA = "0x16E3F90")]
	private void DrawLine(UISprite linesp, Vector3 startpos, Vector3 endpos)
	{
	}

	[Token(Token = "0x6011689")]
	[Address(RVA = "0x16E47AC", Offset = "0x16E47AC", VA = "0x16E47AC")]
	public void SetCurrentMode(uint mode)
	{
	}

	[Token(Token = "0x601168A")]
	[Address(RVA = "0x16E480C", Offset = "0x16E480C", VA = "0x16E480C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601168B")]
	[Address(RVA = "0x16DB854", Offset = "0x16DB854", VA = "0x16DB854")]
	private void PlayAnim(bool Forward)
	{
	}

	[Token(Token = "0x601168C")]
	[Address(RVA = "0x16E489C", Offset = "0x16E489C", VA = "0x16E489C")]
	public void ResetArrowState()
	{
	}

	[Token(Token = "0x601168D")]
	[Address(RVA = "0x16E4ACC", Offset = "0x16E4ACC", VA = "0x16E4ACC")]
	public void ResetState()
	{
	}

	[Token(Token = "0x601168F")]
	[Address(RVA = "0x16E4CF4", Offset = "0x16E4CF4", VA = "0x16E4CF4")]
	private void _003CPlayCommonVfx_003Em__0()
	{
	}

	[Token(Token = "0x6011690")]
	[Address(RVA = "0x16E4CF8", Offset = "0x16E4CF8", VA = "0x16E4CF8")]
	private void _003CPlayCsVfx_003Em__1()
	{
	}

	[Token(Token = "0x6011691")]
	[Address(RVA = "0x16E4CFC", Offset = "0x16E4CFC", VA = "0x16E4CFC")]
	private void _003COnDisableBtn_003Em__2()
	{
	}

	[Token(Token = "0x6011692")]
	[Address(RVA = "0x16E4DF8", Offset = "0x16E4DF8", VA = "0x16E4DF8")]
	private void _003CResetArrowState_003Em__3()
	{
	}

	[Token(Token = "0x6011693")]
	[Address(RVA = "0x16E4E5C", Offset = "0x16E4E5C", VA = "0x16E4E5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011694")]
	[Address(RVA = "0x16E4E64", Offset = "0x16E4E64", VA = "0x16E4E64")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
