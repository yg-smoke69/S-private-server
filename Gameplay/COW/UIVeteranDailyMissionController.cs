using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BD2")]
internal class UIVeteranDailyMissionController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x2002BD3")]
	private enum MentorTaskOperateState
	{
		[Token(Token = "0x4010BCB")]
		None,
		[Token(Token = "0x4010BCC")]
		UnFinished,
		[Token(Token = "0x4010BCD")]
		Claimable,
		[Token(Token = "0x4010BCE")]
		Finished
	}

	[Token(Token = "0x2002BD4")]
	private sealed class _003CAutoShowMentorTask_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010BCF")]
		[FieldOffset(Offset = "0x8")]
		internal UIVeteranDailyMissionController _0024this;

		[Token(Token = "0x4010BD0")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010BD1")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010BD2")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001305")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012238")]
			[Address(RVA = "0x284CFAC", Offset = "0x284CFAC", VA = "0x284CFAC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001306")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012239")]
			[Address(RVA = "0x284CFB4", Offset = "0x284CFB4", VA = "0x284CFB4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012236")]
		[Address(RVA = "0x284ABE8", Offset = "0x284ABE8", VA = "0x284ABE8")]
		public _003CAutoShowMentorTask_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012237")]
		[Address(RVA = "0x284CDDC", Offset = "0x284CDDC", VA = "0x284CDDC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601223A")]
		[Address(RVA = "0x284CFBC", Offset = "0x284CFBC", VA = "0x284CFBC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601223B")]
		[Address(RVA = "0x284CFD0", Offset = "0x284CFD0", VA = "0x284CFD0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BD5")]
	private sealed class _003CAutoShowDailyMisson_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010BD3")]
		[FieldOffset(Offset = "0x8")]
		internal UIVeteranDailyMissionController _0024this;

		[Token(Token = "0x4010BD4")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010BD5")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010BD6")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001307")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601223E")]
			[Address(RVA = "0x284CA3C", Offset = "0x284CA3C", VA = "0x284CA3C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001308")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601223F")]
			[Address(RVA = "0x284CA44", Offset = "0x284CA44", VA = "0x284CA44", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601223C")]
		[Address(RVA = "0x284ABF0", Offset = "0x284ABF0", VA = "0x284ABF0")]
		public _003CAutoShowDailyMisson_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601223D")]
		[Address(RVA = "0x284C8C4", Offset = "0x284C8C4", VA = "0x284C8C4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012240")]
		[Address(RVA = "0x284CA4C", Offset = "0x284CA4C", VA = "0x284CA4C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012241")]
		[Address(RVA = "0x284CA60", Offset = "0x284CA60", VA = "0x284CA60", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BD6")]
	private sealed class _003CAutoShowDailyMissonItem_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010BD7")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x4010BD8")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranDailyMissionController _0024this;

		[Token(Token = "0x4010BD9")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4010BDA")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4010BDB")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001309")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012244")]
			[Address(RVA = "0x284CD30", Offset = "0x284CD30", VA = "0x284CD30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700130A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012245")]
			[Address(RVA = "0x284CD38", Offset = "0x284CD38", VA = "0x284CD38", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012242")]
		[Address(RVA = "0x284ACE4", Offset = "0x284ACE4", VA = "0x284ACE4")]
		public _003CAutoShowDailyMissonItem_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x6012243")]
		[Address(RVA = "0x284CAE8", Offset = "0x284CAE8", VA = "0x284CAE8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012246")]
		[Address(RVA = "0x284CD40", Offset = "0x284CD40", VA = "0x284CD40", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012247")]
		[Address(RVA = "0x284CD54", Offset = "0x284CD54", VA = "0x284CD54", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BD7")]
	private sealed class _003CTokenVFXCoroutine_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010BDC")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x4010BDD")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x4010BDE")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x4010BDF")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x4010BE0")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x4010BE1")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x4010BE2")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x4010BE3")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x4010BE4")]
		[FieldOffset(Offset = "0x50")]
		internal UIVeteranDailyMissionController _0024this;

		[Token(Token = "0x4010BE5")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x4010BE6")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x4010BE7")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x1700130B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601224A")]
			[Address(RVA = "0x284DAC0", Offset = "0x284DAC0", VA = "0x284DAC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700130C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601224B")]
			[Address(RVA = "0x284DAC8", Offset = "0x284DAC8", VA = "0x284DAC8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012248")]
		[Address(RVA = "0x284C408", Offset = "0x284C408", VA = "0x284C408")]
		public _003CTokenVFXCoroutine_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x6012249")]
		[Address(RVA = "0x284D398", Offset = "0x284D398", VA = "0x284D398", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601224C")]
		[Address(RVA = "0x284DAD0", Offset = "0x284DAD0", VA = "0x284DAD0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601224D")]
		[Address(RVA = "0x284DAE4", Offset = "0x284DAE4", VA = "0x284DAE4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BD8")]
	private sealed class _003CPlayProgressAnim_003Ec__Iterator4 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010BE8")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cstart_value_003E__1;

		[Token(Token = "0x4010BE9")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cend_value_003E__1;

		[Token(Token = "0x4010BEA")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CperTimeChange_003E__1;

		[Token(Token = "0x4010BEB")]
		[FieldOffset(Offset = "0x14")]
		internal float _003Ccur_time_003E__1;

		[Token(Token = "0x4010BEC")]
		[FieldOffset(Offset = "0x18")]
		internal UIVeteranDailyMissionController _0024this;

		[Token(Token = "0x4010BED")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x4010BEE")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x4010BEF")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x1700130D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012250")]
			[Address(RVA = "0x284D2EC", Offset = "0x284D2EC", VA = "0x284D2EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700130E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012251")]
			[Address(RVA = "0x284D2F4", Offset = "0x284D2F4", VA = "0x284D2F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601224E")]
		[Address(RVA = "0x284C4DC", Offset = "0x284C4DC", VA = "0x284C4DC")]
		public _003CPlayProgressAnim_003Ec__Iterator4()
		{
		}

		[Token(Token = "0x601224F")]
		[Address(RVA = "0x284D058", Offset = "0x284D058", VA = "0x284D058", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012252")]
		[Address(RVA = "0x284D2FC", Offset = "0x284D2FC", VA = "0x284D2FC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012253")]
		[Address(RVA = "0x284D310", Offset = "0x284D310", VA = "0x284D310", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010BBF")]
	private const int DAYLITASKCOUNT = 4;

	[Token(Token = "0x4010BC0")]
	private const int DAYLITASKAWARDCOUNT = 3;

	[Token(Token = "0x4010BC1")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelVeteranSignin m_VeteranSignInModel;

	[Token(Token = "0x4010BC2")]
	[FieldOffset(Offset = "0x80")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010BC3")]
	[FieldOffset(Offset = "0x84")]
	private UIModelAnnoucementReward m_ModelAnnouncement;

	[Token(Token = "0x4010BC4")]
	[FieldOffset(Offset = "0x88")]
	private UIVeteranDailyMissionView m_View;

	[Token(Token = "0x4010BC5")]
	[FieldOffset(Offset = "0x8C")]
	private List<UIVeteranDailyMissionItemController> m_VeteranDailyTaskList;

	[Token(Token = "0x4010BC6")]
	[FieldOffset(Offset = "0x90")]
	private List<UIStandardItemMiniController> m_UIStandardItemMiniControllers;

	[Token(Token = "0x4010BC7")]
	[FieldOffset(Offset = "0x94")]
	private MentorTaskOperateState m_State;

	[Token(Token = "0x4010BC8")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine m_ProgressCoroutine;

	[Token(Token = "0x4010BC9")]
	[FieldOffset(Offset = "0x9C")]
	private Coroutine m_VFXCoroutine;

	[Token(Token = "0x601220D")]
	[Address(RVA = "0x2847600", Offset = "0x2847600", VA = "0x2847600")]
	public UIVeteranDailyMissionController()
	{
	}

	[Token(Token = "0x601220E")]
	[Address(RVA = "0x28476C0", Offset = "0x28476C0", VA = "0x28476C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601220F")]
	[Address(RVA = "0x2847764", Offset = "0x2847764", VA = "0x2847764", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012210")]
	[Address(RVA = "0x28480A4", Offset = "0x28480A4", VA = "0x28480A4", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6012211")]
	[Address(RVA = "0x28484D8", Offset = "0x28484D8", VA = "0x28484D8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6012212")]
	[Address(RVA = "0x284861C", Offset = "0x284861C", VA = "0x284861C", Slot = "45")]
	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6012213")]
	[Address(RVA = "0x2848674", Offset = "0x2848674", VA = "0x2848674", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6012214")]
	[Address(RVA = "0x284909C", Offset = "0x284909C", VA = "0x284909C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6012215")]
	[Address(RVA = "0x2847D88", Offset = "0x2847D88", VA = "0x2847D88")]
	private void InitItems()
	{
	}

	[Token(Token = "0x6012216")]
	[Address(RVA = "0x284801C", Offset = "0x284801C", VA = "0x284801C")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x6012217")]
	[Address(RVA = "0x2848C44", Offset = "0x2848C44", VA = "0x2848C44")]
	private void RefreshAvatarCloth()
	{
	}

	[Token(Token = "0x6012218")]
	[Address(RVA = "0x284874C", Offset = "0x284874C", VA = "0x284874C")]
	private void RefreshUIView(bool refreshProgress)
	{
	}

	[Token(Token = "0x6012219")]
	[Address(RVA = "0x2849338", Offset = "0x2849338", VA = "0x2849338")]
	private void RefreshProgress()
	{
	}

	[Token(Token = "0x601221A")]
	[Address(RVA = "0x28497B0", Offset = "0x28497B0", VA = "0x28497B0")]
	private void RefreshNormalTask()
	{
	}

	[Token(Token = "0x601221B")]
	[Address(RVA = "0x28491A0", Offset = "0x28491A0", VA = "0x28491A0")]
	private IEnumerator AutoShowMentorTask()
	{
		return null;
	}

	[Token(Token = "0x601221C")]
	[Address(RVA = "0x284926C", Offset = "0x284926C", VA = "0x284926C")]
	private IEnumerator AutoShowDailyMisson()
	{
		return null;
	}

	[Token(Token = "0x601221D")]
	[Address(RVA = "0x284ABF8", Offset = "0x284ABF8", VA = "0x284ABF8")]
	private IEnumerator AutoShowDailyMissonItem(int index)
	{
		return null;
	}

	[Token(Token = "0x601221E")]
	[Address(RVA = "0x2849940", Offset = "0x2849940", VA = "0x2849940")]
	private void RefreshMentorTask()
	{
	}

	[Token(Token = "0x601221F")]
	[Address(RVA = "0x2849474", Offset = "0x2849474", VA = "0x2849474")]
	private void RefreshDoneLabel()
	{
	}

	[Token(Token = "0x6012220")]
	[Address(RVA = "0x284ACEC", Offset = "0x284ACEC", VA = "0x284ACEC")]
	private void OnDoneGotoBtnClick()
	{
	}

	[Token(Token = "0x6012221")]
	[Address(RVA = "0x284B290", Offset = "0x284B290", VA = "0x284B290")]
	private void OnNoMissionGoto()
	{
	}

	[Token(Token = "0x6012222")]
	[Address(RVA = "0x284B600", Offset = "0x284B600", VA = "0x284B600")]
	private void OnMentorTaskButtonClick()
	{
	}

	[Token(Token = "0x6012223")]
	[Address(RVA = "0x2848108", Offset = "0x2848108", VA = "0x2848108")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x6012224")]
	[Address(RVA = "0x284B9E8", Offset = "0x284B9E8", VA = "0x284B9E8")]
	private void OnClose()
	{
	}

	[Token(Token = "0x6012225")]
	[Address(RVA = "0x284BAD8", Offset = "0x284BAD8", VA = "0x284BAD8")]
	private void OnChooseBtnClick()
	{
	}

	[Token(Token = "0x6012226")]
	[Address(RVA = "0x284BE28", Offset = "0x284BE28", VA = "0x284BE28")]
	private void GotoChoose()
	{
	}

	[Token(Token = "0x6012227")]
	[Address(RVA = "0x284C004", Offset = "0x284C004", VA = "0x284C004")]
	private void OnGetTaskReward(object[] objs)
	{
	}

	[Token(Token = "0x6012228")]
	[Address(RVA = "0x284C33C", Offset = "0x284C33C", VA = "0x284C33C")]
	private IEnumerator TokenVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6012229")]
	[Address(RVA = "0x284C410", Offset = "0x284C410", VA = "0x284C410")]
	private IEnumerator PlayProgressAnim()
	{
		return null;
	}

	[Token(Token = "0x601222A")]
	[Address(RVA = "0x284C4E4", Offset = "0x284C4E4", VA = "0x284C4E4", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601222B")]
	[Address(RVA = "0x284C578", Offset = "0x284C578", VA = "0x284C578", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601222C")]
	[Address(RVA = "0x284C6E8", Offset = "0x284C6E8", VA = "0x284C6E8", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x601222D")]
	[Address(RVA = "0x284C758", Offset = "0x284C758", VA = "0x284C758", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x601222E")]
	[Address(RVA = "0x284C7B0", Offset = "0x284C7B0", VA = "0x284C7B0")]
	private void _003CRefreshUIView_003Em__0()
	{
	}

	[Token(Token = "0x601222F")]
	[Address(RVA = "0x284C7F4", Offset = "0x284C7F4", VA = "0x284C7F4")]
	private void _003COnCloseBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x6012230")]
	[Address(RVA = "0x284C894", Offset = "0x284C894", VA = "0x284C894")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012231")]
	[Address(RVA = "0x284C89C", Offset = "0x284C89C", VA = "0x284C89C")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6012232")]
	[Address(RVA = "0x284C8A4", Offset = "0x284C8A4", VA = "0x284C8A4")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6012233")]
	[Address(RVA = "0x284C8AC", Offset = "0x284C8AC", VA = "0x284C8AC")]
	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6012234")]
	[Address(RVA = "0x284C8B4", Offset = "0x284C8B4", VA = "0x284C8B4")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6012235")]
	[Address(RVA = "0x284C8BC", Offset = "0x284C8BC", VA = "0x284C8BC")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
