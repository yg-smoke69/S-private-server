using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002262")]
public class UILadderPlayerFullScreenAnimation : MonoBehaviour
{
	[Token(Token = "0x2002263")]
	public delegate void PlayNextAni();

	[Token(Token = "0x2002264")]
	private sealed class _003CPlayerFullScreenAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D711")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CaniamtionTime_003E__0;

		[Token(Token = "0x400D712")]
		[FieldOffset(Offset = "0xC")]
		internal AnimationClip _003Cclip_003E__0;

		[Token(Token = "0x400D713")]
		[FieldOffset(Offset = "0x10")]
		internal UILadderPlayerFullScreenAnimation _0024this;

		[Token(Token = "0x400D714")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400D715")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400D716")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001087")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BBDB")]
			[Address(RVA = "0x22D9AB0", Offset = "0x22D9AB0", VA = "0x22D9AB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001088")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BBDC")]
			[Address(RVA = "0x22D9AB8", Offset = "0x22D9AB8", VA = "0x22D9AB8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BBD9")]
		[Address(RVA = "0x22D93C0", Offset = "0x22D93C0", VA = "0x22D93C0")]
		public _003CPlayerFullScreenAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BBDA")]
		[Address(RVA = "0x22D9420", Offset = "0x22D9420", VA = "0x22D9420", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BBDD")]
		[Address(RVA = "0x22D9AC0", Offset = "0x22D9AC0", VA = "0x22D9AC0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BBDE")]
		[Address(RVA = "0x22D9AD4", Offset = "0x22D9AD4", VA = "0x22D9AD4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D70A")]
	[FieldOffset(Offset = "0xC")]
	private Animation m_FullScreenAnimationContainer;

	[Token(Token = "0x400D70B")]
	[FieldOffset(Offset = "0x10")]
	private string ANIMATION_RANK_GREATE_UP;

	[Token(Token = "0x400D70C")]
	[FieldOffset(Offset = "0x14")]
	private bool isBr;

	[Token(Token = "0x400D70D")]
	[FieldOffset(Offset = "0x18")]
	private GameObject aniGo;

	[Token(Token = "0x400D70E")]
	[FieldOffset(Offset = "0x1C")]
	public PlayNextAni OnPlayNextAni;

	[Token(Token = "0x400D70F")]
	[FieldOffset(Offset = "0x20")]
	public bool beginNext;

	[Token(Token = "0x400D710")]
	[FieldOffset(Offset = "0x24")]
	private UILadderAnimationParam animationParam;

	[Token(Token = "0x600BBD0")]
	[Address(RVA = "0x22D8D4C", Offset = "0x22D8D4C", VA = "0x22D8D4C")]
	public UILadderPlayerFullScreenAnimation()
	{
	}

	[Token(Token = "0x600BBD1")]
	[Address(RVA = "0x22D8DC0", Offset = "0x22D8DC0", VA = "0x22D8DC0")]
	public void InstantiatePrefabAni(Transform aniTrans, ResourceID resID, string clipName)
	{
	}

	[Token(Token = "0x600BBD2")]
	[Address(RVA = "0x22D90F0", Offset = "0x22D90F0", VA = "0x22D90F0")]
	public void InitAniParam(string beforeRankName, string afterRankName, ResourceID beforeRankIcon, ResourceID afterRankIcon, bool isBr = true)
	{
	}

	[Token(Token = "0x600BBD3")]
	[Address(RVA = "0x22D92F4", Offset = "0x22D92F4", VA = "0x22D92F4")]
	public IEnumerator PlayerFullScreenAnimation()
	{
		return null;
	}

	[Token(Token = "0x600BBD4")]
	[Address(RVA = "0x22D93C8", Offset = "0x22D93C8", VA = "0x22D93C8")]
	private void Update()
	{
	}
}
