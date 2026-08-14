using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E2B")]
public class TestSceneLoopManager : MonoSingleton<TestSceneLoopManager>
{
	[Token(Token = "0x2001E2C")]
	private sealed class _003CTestSceneSingleCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400BE91")]
		[FieldOffset(Offset = "0x8")]
		internal uint mapID;

		[Token(Token = "0x400BE92")]
		[FieldOffset(Offset = "0xC")]
		internal MapConfigData _003CconfigData_003E__1;

		[Token(Token = "0x400BE93")]
		[FieldOffset(Offset = "0x10")]
		internal Player _003Clocal_player_003E__1;

		[Token(Token = "0x400BE94")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CcurPos_003E__1;

		[Token(Token = "0x400BE95")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CtarPos_003E__1;

		[Token(Token = "0x400BE96")]
		[FieldOffset(Offset = "0x2C")]
		internal string _003Ccmd_003E__1;

		[Token(Token = "0x400BE97")]
		[FieldOffset(Offset = "0x30")]
		internal MatchGame _003Ccgame_003E__1;

		[Token(Token = "0x400BE98")]
		[FieldOffset(Offset = "0x34")]
		internal object _0024current;

		[Token(Token = "0x400BE99")]
		[FieldOffset(Offset = "0x38")]
		internal bool _0024disposing;

		[Token(Token = "0x400BE9A")]
		[FieldOffset(Offset = "0x3C")]
		internal int _0024PC;

		[Token(Token = "0x17000F25")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009086")]
			[Address(RVA = "0x28A6110", Offset = "0x28A6110", VA = "0x28A6110", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F26")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009087")]
			[Address(RVA = "0x28A6118", Offset = "0x28A6118", VA = "0x28A6118", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009084")]
		[Address(RVA = "0x28A42E8", Offset = "0x28A42E8", VA = "0x28A42E8")]
		public _003CTestSceneSingleCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009085")]
		[Address(RVA = "0x28A5408", Offset = "0x28A5408", VA = "0x28A5408", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009088")]
		[Address(RVA = "0x28A6120", Offset = "0x28A6120", VA = "0x28A6120", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009089")]
		[Address(RVA = "0x28A6134", Offset = "0x28A6134", VA = "0x28A6134", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001E2D")]
	private sealed class _003CTestSceneMultiCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400BE9B")]
		[FieldOffset(Offset = "0x8")]
		internal uint mapID;

		[Token(Token = "0x400BE9C")]
		[FieldOffset(Offset = "0xC")]
		internal uint gameMode;

		[Token(Token = "0x400BE9D")]
		[FieldOffset(Offset = "0x10")]
		internal Player _003Clocal_player_003E__1;

		[Token(Token = "0x400BE9E")]
		[FieldOffset(Offset = "0x14")]
		internal Player _003Clocal_player_003E__2;

		[Token(Token = "0x400BE9F")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003CcurPos_003E__3;

		[Token(Token = "0x400BEA0")]
		[FieldOffset(Offset = "0x24")]
		internal Vector3 _003CtarPos_003E__3;

		[Token(Token = "0x400BEA1")]
		[FieldOffset(Offset = "0x30")]
		internal string _003Ccmd_003E__3;

		[Token(Token = "0x400BEA2")]
		[FieldOffset(Offset = "0x34")]
		internal MatchGame _003Ccgame_003E__3;

		[Token(Token = "0x400BEA3")]
		[FieldOffset(Offset = "0x38")]
		internal TestSceneLoopManager _0024this;

		[Token(Token = "0x400BEA4")]
		[FieldOffset(Offset = "0x3C")]
		internal object _0024current;

		[Token(Token = "0x400BEA5")]
		[FieldOffset(Offset = "0x40")]
		internal bool _0024disposing;

		[Token(Token = "0x400BEA6")]
		[FieldOffset(Offset = "0x44")]
		internal int _0024PC;

		[Token(Token = "0x17000F27")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600908C")]
			[Address(RVA = "0x28A535C", Offset = "0x28A535C", VA = "0x28A535C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F28")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600908D")]
			[Address(RVA = "0x28A5364", Offset = "0x28A5364", VA = "0x28A5364", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600908A")]
		[Address(RVA = "0x28A43A8", Offset = "0x28A43A8", VA = "0x28A43A8")]
		public _003CTestSceneMultiCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600908B")]
		[Address(RVA = "0x28A43B0", Offset = "0x28A43B0", VA = "0x28A43B0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600908E")]
		[Address(RVA = "0x28A536C", Offset = "0x28A536C", VA = "0x28A536C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600908F")]
		[Address(RVA = "0x28A5380", Offset = "0x28A5380", VA = "0x28A5380", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400BE8D")]
	[FieldOffset(Offset = "0xC")]
	private uint GameMode;

	[Token(Token = "0x400BE8E")]
	[FieldOffset(Offset = "0x10")]
	private uint MapID;

	[Token(Token = "0x400BE8F")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsSingle;

	[Token(Token = "0x400BE90")]
	[FieldOffset(Offset = "0x15")]
	private bool m_MatchMakingCancled;

	[Token(Token = "0x17000F24")]
	public bool MatchMakingCancled
	{
		[Token(Token = "0x6009082")]
		[Address(RVA = "0x28A4350", Offset = "0x28A4350", VA = "0x28A4350")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009081")]
		[Address(RVA = "0x28A42F0", Offset = "0x28A42F0", VA = "0x28A42F0")]
		set
		{
		}
	}

	[Token(Token = "0x600907D")]
	[Address(RVA = "0x28A3DB4", Offset = "0x28A3DB4", VA = "0x28A3DB4")]
	public TestSceneLoopManager()
	{
	}

	[Token(Token = "0x600907E")]
	[Address(RVA = "0x28A3E4C", Offset = "0x28A3E4C", VA = "0x28A3E4C")]
	public void StartTestSceneLoop(uint game_mode, uint mapID, bool is_single)
	{
	}

	[Token(Token = "0x600907F")]
	[Address(RVA = "0x28A41D4", Offset = "0x28A41D4", VA = "0x28A41D4")]
	public void StopTestSceneLoop()
	{
	}

	[Token(Token = "0x6009080")]
	[Address(RVA = "0x28A3FD0", Offset = "0x28A3FD0", VA = "0x28A3FD0")]
	private IEnumerator TestSceneSingleCoroutine(uint game_mode, uint mapID)
	{
		return null;
	}

	[Token(Token = "0x6009083")]
	[Address(RVA = "0x28A40BC", Offset = "0x28A40BC", VA = "0x28A40BC")]
	private IEnumerator TestSceneMultiCoroutine(uint gameMode, uint mapID)
	{
		return null;
	}
}
