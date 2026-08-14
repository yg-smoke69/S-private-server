using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FAB")]
public class UIAvatarAwakenController : UIBaseController, _Attribute
{
	[Token(Token = "0x2001FAC")]
	private sealed class _003CShowUnlockComicEffect_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C69D")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CCurShowIndex_003E__0;

		[Token(Token = "0x400C69E")]
		[FieldOffset(Offset = "0xC")]
		internal uint unlockNum;

		[Token(Token = "0x400C69F")]
		[FieldOffset(Offset = "0x10")]
		internal UIAvatarAwakenController _0024this;

		[Token(Token = "0x400C6A0")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C6A1")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C6A2")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000FA0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009E2B")]
			[Address(RVA = "0x1E808AC", Offset = "0x1E808AC", VA = "0x1E808AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FA1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009E2C")]
			[Address(RVA = "0x1E808B4", Offset = "0x1E808B4", VA = "0x1E808B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009E29")]
		[Address(RVA = "0x1E7F5A8", Offset = "0x1E7F5A8", VA = "0x1E7F5A8")]
		public _003CShowUnlockComicEffect_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009E2A")]
		[Address(RVA = "0x1E8070C", Offset = "0x1E8070C", VA = "0x1E8070C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009E2D")]
		[Address(RVA = "0x1E808BC", Offset = "0x1E808BC", VA = "0x1E808BC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009E2E")]
		[Address(RVA = "0x1E808D0", Offset = "0x1E808D0", VA = "0x1E808D0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FAD")]
	private sealed class _003CShowComicProgressAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C6A3")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CanimationTime_003E__0;

		[Token(Token = "0x400C6A4")]
		[FieldOffset(Offset = "0xC")]
		internal float _003ColdValue_003E__0;

		[Token(Token = "0x400C6A5")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CnewValue_003E__0;

		[Token(Token = "0x400C6A6")]
		[FieldOffset(Offset = "0x14")]
		internal List<AvatarAwakenComicData> _003CdataList_003E__0;

		[Token(Token = "0x400C6A7")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003Cfinish_003E__0;

		[Token(Token = "0x400C6A8")]
		[FieldOffset(Offset = "0x1C")]
		internal UIAvatarAwakenController _0024this;

		[Token(Token = "0x400C6A9")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400C6AA")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400C6AB")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17000FA2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009E31")]
			[Address(RVA = "0x1E80660", Offset = "0x1E80660", VA = "0x1E80660", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FA3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009E32")]
			[Address(RVA = "0x1E80668", Offset = "0x1E80668", VA = "0x1E80668", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009E2F")]
		[Address(RVA = "0x1E7F67C", Offset = "0x1E7F67C", VA = "0x1E7F67C")]
		public _003CShowComicProgressAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6009E30")]
		[Address(RVA = "0x1E80210", Offset = "0x1E80210", VA = "0x1E80210", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009E33")]
		[Address(RVA = "0x1E80670", Offset = "0x1E80670", VA = "0x1E80670", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009E34")]
		[Address(RVA = "0x1E80684", Offset = "0x1E80684", VA = "0x1E80684", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FAE")]
	private sealed class _003CWaitForAnimationFinish_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C6AC")]
		[FieldOffset(Offset = "0x8")]
		internal float animationTime;

		[Token(Token = "0x400C6AD")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C6AE")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C6AF")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009E37")]
			[Address(RVA = "0x1E809D4", Offset = "0x1E809D4", VA = "0x1E809D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009E38")]
			[Address(RVA = "0x1E809DC", Offset = "0x1E809DC", VA = "0x1E809DC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009E35")]
		[Address(RVA = "0x1E7F768", Offset = "0x1E7F768", VA = "0x1E7F768")]
		public _003CWaitForAnimationFinish_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x6009E36")]
		[Address(RVA = "0x1E80958", Offset = "0x1E80958", VA = "0x1E80958", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009E39")]
		[Address(RVA = "0x1E809E4", Offset = "0x1E809E4", VA = "0x1E809E4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009E3A")]
		[Address(RVA = "0x1E809F8", Offset = "0x1E809F8", VA = "0x1E809F8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C68E")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarAwakenView m_View;

	[Token(Token = "0x400C68F")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400C690")]
	[FieldOffset(Offset = "0x30")]
	private AvatarProfile m_CurrentShowAvatar;

	[Token(Token = "0x400C691")]
	[FieldOffset(Offset = "0x34")]
	private List<UIAvatarAwakenTaskItemController> m_CacheTaskItemList;

	[Token(Token = "0x400C692")]
	[FieldOffset(Offset = "0x38")]
	private List<UIAvatarAwakenStoryItemController> m_CacheStoryItemList;

	[Token(Token = "0x400C693")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_TaskPosList;

	[Token(Token = "0x400C694")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> m_TaskEffectList;

	[Token(Token = "0x400C695")]
	[FieldOffset(Offset = "0x44")]
	private List<GameObject> m_ComicEffectList;

	[Token(Token = "0x400C696")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> m_ComicCanUnlockEffectList;

	[Token(Token = "0x400C697")]
	[FieldOffset(Offset = "0x4C")]
	private List<GameObject> m_ComicUnlockEffectList;

	[Token(Token = "0x400C698")]
	[FieldOffset(Offset = "0x50")]
	private int ComicCntMax;

	[Token(Token = "0x400C699")]
	[FieldOffset(Offset = "0x54")]
	private int m_CurrentIndex;

	[Token(Token = "0x400C69A")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CurrentFinishTaskID;

	[Token(Token = "0x400C69B")]
	[FieldOffset(Offset = "0x5C")]
	private IEnumerator m_CurrentAnim;

	[Token(Token = "0x400C69C")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009DFC")]
	[Address(RVA = "0x1E78664", Offset = "0x1E78664", VA = "0x1E78664")]
	public UIAvatarAwakenController()
	{
	}

	[Token(Token = "0x6009DFD")]
	[Address(RVA = "0x1E78758", Offset = "0x1E78758", VA = "0x1E78758")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DFE")]
	[Address(RVA = "0x1E787FC", Offset = "0x1E787FC", VA = "0x1E787FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DFF")]
	[Address(RVA = "0x1E79444", Offset = "0x1E79444", VA = "0x1E79444")]
	private void OnShowAwardTips()
	{
	}

	[Token(Token = "0x6009E00")]
	[Address(RVA = "0x1E7968C", Offset = "0x1E7968C", VA = "0x1E7968C")]
	private void OnMoveToNextComic()
	{
	}

	[Token(Token = "0x6009E01")]
	[Address(RVA = "0x1E79A4C", Offset = "0x1E79A4C", VA = "0x1E79A4C")]
	private void OnMoveToLastComic()
	{
	}

	[Token(Token = "0x6009E02")]
	[Address(RVA = "0x1E79AB0", Offset = "0x1E79AB0", VA = "0x1E79AB0")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x6009E03")]
	[Address(RVA = "0x1E7A03C", Offset = "0x1E7A03C", VA = "0x1E7A03C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009E04")]
	[Address(RVA = "0x1E7A148", Offset = "0x1E7A148", VA = "0x1E7A148")]
	private void RefreshTaskConfirm()
	{
	}

	[Token(Token = "0x6009E05")]
	[Address(RVA = "0x1E7AA78", Offset = "0x1E7AA78", VA = "0x1E7AA78")]
	public void SetAvatar(uint curAvatarID)
	{
	}

	[Token(Token = "0x6009E06")]
	[Address(RVA = "0x1E7AB80", Offset = "0x1E7AB80", VA = "0x1E7AB80")]
	private void SetCDNList()
	{
	}

	[Token(Token = "0x6009E07")]
	[Address(RVA = "0x1E7AC24", Offset = "0x1E7AC24", VA = "0x1E7AC24")]
	private void InitStoryList()
	{
	}

	[Token(Token = "0x6009E08")]
	[Address(RVA = "0x1E796F0", Offset = "0x1E796F0", VA = "0x1E796F0")]
	private void MoveIndexCount(int moveCnt)
	{
	}

	[Token(Token = "0x6009E09")]
	[Address(RVA = "0x1E7BCA8", Offset = "0x1E7BCA8", VA = "0x1E7BCA8")]
	private void RefreshStoryList()
	{
	}

	[Token(Token = "0x6009E0A")]
	[Address(RVA = "0x1E7B670", Offset = "0x1E7B670", VA = "0x1E7B670")]
	private void ShowCurrentComicEffect()
	{
	}

	[Token(Token = "0x6009E0B")]
	[Address(RVA = "0x1E7C5E4", Offset = "0x1E7C5E4", VA = "0x1E7C5E4")]
	private void RefreshFinishProgress()
	{
	}

	[Token(Token = "0x6009E0C")]
	[Address(RVA = "0x1E7C8A4", Offset = "0x1E7C8A4", VA = "0x1E7C8A4")]
	private void RefreshAwakenBtnState()
	{
	}

	[Token(Token = "0x6009E0D")]
	[Address(RVA = "0x1E7CC30", Offset = "0x1E7CC30", VA = "0x1E7CC30")]
	private void RefreshTaskResetBtnState()
	{
	}

	[Token(Token = "0x6009E0E")]
	[Address(RVA = "0x1E7AB08", Offset = "0x1E7AB08", VA = "0x1E7AB08")]
	private void InitUI()
	{
	}

	[Token(Token = "0x6009E0F")]
	[Address(RVA = "0x1E7D098", Offset = "0x1E7D098", VA = "0x1E7D098")]
	private void SetDescription()
	{
	}

	[Token(Token = "0x6009E10")]
	[Address(RVA = "0x1E7D288", Offset = "0x1E7D288", VA = "0x1E7D288")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6009E11")]
	[Address(RVA = "0x1E7D234", Offset = "0x1E7D234", VA = "0x1E7D234")]
	private void RefreshSkill()
	{
	}

	[Token(Token = "0x6009E12")]
	[Address(RVA = "0x1E7D860", Offset = "0x1E7D860", VA = "0x1E7D860")]
	private void CheckLockState()
	{
	}

	[Token(Token = "0x6009E13")]
	[Address(RVA = "0x1E7DC48", Offset = "0x1E7DC48", VA = "0x1E7DC48", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009E14")]
	[Address(RVA = "0x1E7DCAC", Offset = "0x1E7DCAC", VA = "0x1E7DCAC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009E15")]
	[Address(RVA = "0x1E7DEAC", Offset = "0x1E7DEAC", VA = "0x1E7DEAC")]
	private void OnGainAvatarBtnClick()
	{
	}

	[Token(Token = "0x6009E16")]
	[Address(RVA = "0x1E7E1B0", Offset = "0x1E7E1B0", VA = "0x1E7E1B0")]
	private void OnAwakenDisableBtnClick()
	{
	}

	[Token(Token = "0x6009E17")]
	[Address(RVA = "0x1E7E3DC", Offset = "0x1E7E3DC", VA = "0x1E7E3DC")]
	private void OnClaimAwakenAvatarBtnClick()
	{
	}

	[Token(Token = "0x6009E18")]
	[Address(RVA = "0x1E7E590", Offset = "0x1E7E590", VA = "0x1E7E590")]
	private void OnUpgradeSkillBtnClick()
	{
	}

	[Token(Token = "0x6009E19")]
	[Address(RVA = "0x1E7D310", Offset = "0x1E7D310", VA = "0x1E7D310")]
	private void RefreshTaskList()
	{
	}

	[Token(Token = "0x6009E1A")]
	[Address(RVA = "0x1E7EE8C", Offset = "0x1E7EE8C", VA = "0x1E7EE8C")]
	private int SortItem(AvatarAwakenComicData a, AvatarAwakenComicData b)
	{
		return default(int);
	}

	[Token(Token = "0x6009E1B")]
	[Address(RVA = "0x1E7EF30", Offset = "0x1E7EF30", VA = "0x1E7EF30")]
	private void OnAwakenRewardClaim(object[] data)
	{
	}

	[Token(Token = "0x6009E1C")]
	[Address(RVA = "0x1E7EF8C", Offset = "0x1E7EF8C", VA = "0x1E7EF8C", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009E1D")]
	[Address(RVA = "0x1E7F048", Offset = "0x1E7F048", VA = "0x1E7F048", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009E1E")]
	[Address(RVA = "0x1E7F4BC", Offset = "0x1E7F4BC", VA = "0x1E7F4BC")]
	private IEnumerator ShowUnlockComicEffect(uint unlockNum)
	{
		return null;
	}

	[Token(Token = "0x6009E1F")]
	[Address(RVA = "0x1E7F5B0", Offset = "0x1E7F5B0", VA = "0x1E7F5B0")]
	private IEnumerator ShowComicProgressAnim()
	{
		return null;
	}

	[Token(Token = "0x6009E20")]
	[Address(RVA = "0x1E7F684", Offset = "0x1E7F684", VA = "0x1E7F684")]
	private IEnumerator WaitForAnimationFinish(float animationTime)
	{
		return null;
	}

	[Token(Token = "0x6009E21")]
	[Address(RVA = "0x1E7F770", Offset = "0x1E7F770", VA = "0x1E7F770")]
	private void ShowTaskClaimEffect()
	{
	}

	[Token(Token = "0x6009E22")]
	[Address(RVA = "0x1E7FBCC", Offset = "0x1E7FBCC", VA = "0x1E7FBCC")]
	private void ShowUnlockOnceEffect(uint unlockNum)
	{
	}

	[Token(Token = "0x6009E23")]
	[Address(RVA = "0x1E7FED0", Offset = "0x1E7FED0", VA = "0x1E7FED0")]
	private void ShowComicClaimEffect(uint unlockNum)
	{
	}

	[Token(Token = "0x6009E24")]
	[Address(RVA = "0x1E80158", Offset = "0x1E80158", VA = "0x1E80158")]
	private static void _003CRefreshTaskConfirm_003Em__0()
	{
	}

	[Token(Token = "0x6009E25")]
	[Address(RVA = "0x1E801F0", Offset = "0x1E801F0", VA = "0x1E801F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009E26")]
	[Address(RVA = "0x1E801F8", Offset = "0x1E801F8", VA = "0x1E801F8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009E27")]
	[Address(RVA = "0x1E80200", Offset = "0x1E80200", VA = "0x1E80200")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009E28")]
	[Address(RVA = "0x1E80208", Offset = "0x1E80208", VA = "0x1E80208")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
