using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002293")]
internal class UISPHudTeammateMissionItem : MonoBehaviour
{
	[Token(Token = "0x2002294")]
	private sealed class _003CDelayShowResult_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D89B")]
		[FieldOffset(Offset = "0x8")]
		internal UISPHudTeammateMissionItem _0024this;

		[Token(Token = "0x400D89C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D89D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D89E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700108E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BDC2")]
			[Address(RVA = "0x14A0048", Offset = "0x14A0048", VA = "0x14A0048", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700108F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BDC3")]
			[Address(RVA = "0x14A0050", Offset = "0x14A0050", VA = "0x14A0050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BDC0")]
		[Address(RVA = "0x149F8D0", Offset = "0x149F8D0", VA = "0x149F8D0")]
		public _003CDelayShowResult_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BDC1")]
		[Address(RVA = "0x149FD84", Offset = "0x149FD84", VA = "0x149FD84", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BDC4")]
		[Address(RVA = "0x14A0058", Offset = "0x14A0058", VA = "0x14A0058", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BDC5")]
		[Address(RVA = "0x14A006C", Offset = "0x14A006C", VA = "0x14A006C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002295")]
	private sealed class _003CDelayPlayOutAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D89F")]
		[FieldOffset(Offset = "0x8")]
		internal UISPHudTeammateMissionItem _0024this;

		[Token(Token = "0x400D8A0")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D8A1")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D8A2")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001090")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BDC8")]
			[Address(RVA = "0x149FCD8", Offset = "0x149FCD8", VA = "0x149FCD8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001091")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BDC9")]
			[Address(RVA = "0x149FCE0", Offset = "0x149FCE0", VA = "0x149FCE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BDC6")]
		[Address(RVA = "0x149F8D8", Offset = "0x149F8D8", VA = "0x149F8D8")]
		public _003CDelayPlayOutAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600BDC7")]
		[Address(RVA = "0x149FB78", Offset = "0x149FB78", VA = "0x149FB78", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BDCA")]
		[Address(RVA = "0x149FCE8", Offset = "0x149FCE8", VA = "0x149FCE8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BDCB")]
		[Address(RVA = "0x149FCFC", Offset = "0x149FCFC", VA = "0x149FCFC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002296")]
	private sealed class _003CDelayHideItem_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D8A3")]
		[FieldOffset(Offset = "0x8")]
		internal AnimationClip _003CoutClip_003E__0;

		[Token(Token = "0x400D8A4")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CwaitTime_003E__0;

		[Token(Token = "0x400D8A5")]
		[FieldOffset(Offset = "0x10")]
		internal UISPHudTeammateMissionItem _0024this;

		[Token(Token = "0x400D8A6")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400D8A7")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400D8A8")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001092")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BDCE")]
			[Address(RVA = "0x149FACC", Offset = "0x149FACC", VA = "0x149FACC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001093")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BDCF")]
			[Address(RVA = "0x149FAD4", Offset = "0x149FAD4", VA = "0x149FAD4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BDCC")]
		[Address(RVA = "0x149F8E0", Offset = "0x149F8E0", VA = "0x149F8E0")]
		public _003CDelayHideItem_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600BDCD")]
		[Address(RVA = "0x149F8E8", Offset = "0x149F8E8", VA = "0x149F8E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BDD0")]
		[Address(RVA = "0x149FADC", Offset = "0x149FADC", VA = "0x149FADC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BDD1")]
		[Address(RVA = "0x149FAF0", Offset = "0x149FAF0", VA = "0x149FAF0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D88F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject ItemBG;

	[Token(Token = "0x400D890")]
	[FieldOffset(Offset = "0x10")]
	public UISprite MissionIcon;

	[Token(Token = "0x400D891")]
	[FieldOffset(Offset = "0x14")]
	public UIProgressBar Progress;

	[Token(Token = "0x400D892")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MissionLabel;

	[Token(Token = "0x400D893")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CompleteLabel;

	[Token(Token = "0x400D894")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FailedLabel;

	[Token(Token = "0x400D895")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TimeLabel;

	[Token(Token = "0x400D896")]
	[FieldOffset(Offset = "0x28")]
	public Animation missionAnimation;

	[Token(Token = "0x400D897")]
	[FieldOffset(Offset = "0x2C")]
	private float m_TimeCount;

	[Token(Token = "0x400D898")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasTimeWaring;

	[Token(Token = "0x400D899")]
	[FieldOffset(Offset = "0x34")]
	private DEBJENPEHIJ m_GameMission;

	[Token(Token = "0x400D89A")]
	[FieldOffset(Offset = "0x38")]
	private bool m_MissionClosed;

	[Token(Token = "0x600BDB5")]
	[Address(RVA = "0x149E3D0", Offset = "0x149E3D0", VA = "0x149E3D0")]
	public UISPHudTeammateMissionItem()
	{
	}

	[Token(Token = "0x600BDB6")]
	[Address(RVA = "0x149E3D8", Offset = "0x149E3D8", VA = "0x149E3D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BDB7")]
	[Address(RVA = "0x149E584", Offset = "0x149E584", VA = "0x149E584")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600BDB8")]
	[Address(RVA = "0x149E9C0", Offset = "0x149E9C0", VA = "0x149E9C0")]
	private void OnMissionStart(object[] data)
	{
	}

	[Token(Token = "0x600BDB9")]
	[Address(RVA = "0x149EA1C", Offset = "0x149EA1C", VA = "0x149EA1C")]
	private void ShowItem()
	{
	}

	[Token(Token = "0x600BDBA")]
	[Address(RVA = "0x149EC28", Offset = "0x149EC28", VA = "0x149EC28")]
	public void HideItem()
	{
	}

	[Token(Token = "0x600BDBB")]
	[Address(RVA = "0x149ECF0", Offset = "0x149ECF0", VA = "0x149ECF0")]
	public void UpdateMission(DEBJENPEHIJ gameMission)
	{
	}

	[Token(Token = "0x600BDBC")]
	[Address(RVA = "0x149F758", Offset = "0x149F758", VA = "0x149F758")]
	private void OnMissionClose(object[] data)
	{
	}

	[Token(Token = "0x600BDBD")]
	[Address(RVA = "0x149E828", Offset = "0x149E828", VA = "0x149E828")]
	private IEnumerator DelayShowResult()
	{
		return null;
	}

	[Token(Token = "0x600BDBE")]
	[Address(RVA = "0x149E8F4", Offset = "0x149E8F4", VA = "0x149E8F4")]
	private IEnumerator DelayPlayOutAnim()
	{
		return null;
	}

	[Token(Token = "0x600BDBF")]
	[Address(RVA = "0x149E75C", Offset = "0x149E75C", VA = "0x149E75C")]
	private IEnumerator DelayHideItem()
	{
		return null;
	}
}
