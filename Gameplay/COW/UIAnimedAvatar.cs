using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FD3")]
public class UIAnimedAvatar : UIAvatar
{
	[Token(Token = "0x2001FD4")]
	public enum GunType
	{
		[Token(Token = "0x400C810")]
		None,
		[Token(Token = "0x400C811")]
		ShortGun,
		[Token(Token = "0x400C812")]
		ShortGunIdle,
		[Token(Token = "0x400C813")]
		BigGun,
		[Token(Token = "0x400C814")]
		BigGunIdle,
		[Token(Token = "0x400C815")]
		SmallGun,
		[Token(Token = "0x400C816")]
		SmallGunIdle,
		[Token(Token = "0x400C817")]
		Grenade,
		[Token(Token = "0x400C818")]
		GrenadeIdle,
		[Token(Token = "0x400C819")]
		ShotGun,
		[Token(Token = "0x400C81A")]
		ShotGunIdle,
		[Token(Token = "0x400C81B")]
		Gatling,
		[Token(Token = "0x400C81C")]
		GatlingIdle,
		[Token(Token = "0x400C81D")]
		Fist,
		[Token(Token = "0x400C81E")]
		FistAttack,
		[Token(Token = "0x400C81F")]
		DoubleWeapon,
		[Token(Token = "0x400C820")]
		DoubleWeaponIdle,
		[Token(Token = "0x400C821")]
		Katana,
		[Token(Token = "0x400C822")]
		KatanaIdle
	}

	[Token(Token = "0x2001FD5")]
	private class TransCache
	{
		[Token(Token = "0x400C823")]
		[FieldOffset(Offset = "0x8")]
		public Transform Parent;

		[Token(Token = "0x400C824")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 Pos;

		[Token(Token = "0x400C825")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Scale;

		[Token(Token = "0x400C826")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion Rot;

		[Token(Token = "0x600A04F")]
		[Address(RVA = "0x1E6AF38", Offset = "0x1E6AF38", VA = "0x1E6AF38")]
		public TransCache(Transform tr)
		{
		}

		[Token(Token = "0x600A050")]
		[Address(RVA = "0x1E6B01C", Offset = "0x1E6B01C", VA = "0x1E6B01C")]
		public void Apply(Transform tr)
		{
		}
	}

	[Token(Token = "0x2001FD6")]
	private sealed class _003CUpdateDoBackpackUpdate_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C827")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x400C828")]
		[FieldOffset(Offset = "0xC")]
		internal uint level;

		[Token(Token = "0x400C829")]
		[FieldOffset(Offset = "0x10")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C82A")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C82B")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C82C")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000FBE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A053")]
			[Address(RVA = "0x1E6AE8C", Offset = "0x1E6AE8C", VA = "0x1E6AE8C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FBF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A054")]
			[Address(RVA = "0x1E6AE94", Offset = "0x1E6AE94", VA = "0x1E6AE94", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A051")]
		[Address(RVA = "0x1E6ADE0", Offset = "0x1E6ADE0", VA = "0x1E6ADE0")]
		public _003CUpdateDoBackpackUpdate_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A052")]
		[Address(RVA = "0x1E6ADE8", Offset = "0x1E6ADE8", VA = "0x1E6ADE8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A055")]
		[Address(RVA = "0x1E6AE9C", Offset = "0x1E6AE9C", VA = "0x1E6AE9C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A056")]
		[Address(RVA = "0x1E6AEB0", Offset = "0x1E6AEB0", VA = "0x1E6AEB0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FD7")]
	private sealed class _003CCoPlayAnimClipAtLobby_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C82D")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CwaitedFrames_003E__0;

		[Token(Token = "0x400C82E")]
		[FieldOffset(Offset = "0xC")]
		internal ResourceID resId;

		[Token(Token = "0x400C82F")]
		[FieldOffset(Offset = "0x10")]
		internal AnimationClip _003Cclip_003E__0;

		[Token(Token = "0x400C830")]
		[FieldOffset(Offset = "0x14")]
		internal float _003Clength_003E__0;

		[Token(Token = "0x400C831")]
		[FieldOffset(Offset = "0x18")]
		internal bool playIdleAlternate;

		[Token(Token = "0x400C832")]
		[FieldOffset(Offset = "0x19")]
		internal bool loop;

		[Token(Token = "0x400C833")]
		[FieldOffset(Offset = "0x1C")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C834")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400C835")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400C836")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17000FC0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A059")]
			[Address(RVA = "0x1E689A8", Offset = "0x1E689A8", VA = "0x1E689A8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FC1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A05A")]
			[Address(RVA = "0x1E689B0", Offset = "0x1E689B0", VA = "0x1E689B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A057")]
		[Address(RVA = "0x1E68470", Offset = "0x1E68470", VA = "0x1E68470")]
		public _003CCoPlayAnimClipAtLobby_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600A058")]
		[Address(RVA = "0x1E68478", Offset = "0x1E68478", VA = "0x1E68478", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A05B")]
		[Address(RVA = "0x1E689B8", Offset = "0x1E689B8", VA = "0x1E689B8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A05C")]
		[Address(RVA = "0x1E689CC", Offset = "0x1E689CC", VA = "0x1E689CC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FD8")]
	private sealed class _003CCoPlayTransformerAtLobby_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C837")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CwaitedFrames_003E__0;

		[Token(Token = "0x400C838")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CanimEndTime_003E__0;

		[Token(Token = "0x400C839")]
		[FieldOffset(Offset = "0x10")]
		internal TransformData data;

		[Token(Token = "0x400C83A")]
		[FieldOffset(Offset = "0x14")]
		internal ResourceID _003CanimResId_003E__1;

		[Token(Token = "0x400C83B")]
		[FieldOffset(Offset = "0x18")]
		internal AnimationClip _003Cclip_003E__1;

		[Token(Token = "0x400C83C")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003Clength_003E__1;

		[Token(Token = "0x400C83D")]
		[FieldOffset(Offset = "0x20")]
		internal Transform _003CcharacterNode_003E__1;

		[Token(Token = "0x400C83E")]
		[FieldOffset(Offset = "0x24")]
		internal Renderer[] _003CtransformerRenders_003E__1;

		[Token(Token = "0x400C83F")]
		[FieldOffset(Offset = "0x28")]
		internal Renderer[] _0024locvar0;

		[Token(Token = "0x400C840")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024locvar1;

		[Token(Token = "0x400C841")]
		[FieldOffset(Offset = "0x30")]
		internal Animator _003CtransformerAnimator_003E__1;

		[Token(Token = "0x400C842")]
		[FieldOffset(Offset = "0x34")]
		internal bool loop;

		[Token(Token = "0x400C843")]
		[FieldOffset(Offset = "0x38")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C844")]
		[FieldOffset(Offset = "0x3C")]
		internal object _0024current;

		[Token(Token = "0x400C845")]
		[FieldOffset(Offset = "0x40")]
		internal bool _0024disposing;

		[Token(Token = "0x400C846")]
		[FieldOffset(Offset = "0x44")]
		internal int _0024PC;

		[Token(Token = "0x17000FC2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A05F")]
			[Address(RVA = "0x1E6A52C", Offset = "0x1E6A52C", VA = "0x1E6A52C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FC3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A060")]
			[Address(RVA = "0x1E6A534", Offset = "0x1E6A534", VA = "0x1E6A534", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A05D")]
		[Address(RVA = "0x1E69338", Offset = "0x1E69338", VA = "0x1E69338")]
		public _003CCoPlayTransformerAtLobby_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600A05E")]
		[Address(RVA = "0x1E69340", Offset = "0x1E69340", VA = "0x1E69340", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A061")]
		[Address(RVA = "0x1E6A53C", Offset = "0x1E6A53C", VA = "0x1E6A53C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A062")]
		[Address(RVA = "0x1E6A550", Offset = "0x1E6A550", VA = "0x1E6A550", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FD9")]
	private sealed class _003CCoPlayEmotionAnimationd_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C847")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CwaitedFrames_003E__0;

		[Token(Token = "0x400C848")]
		[FieldOffset(Offset = "0xC")]
		internal uint emotionID;

		[Token(Token = "0x400C849")]
		[FieldOffset(Offset = "0x10")]
		internal EmoteData _003CemotionData_003E__0;

		[Token(Token = "0x400C84A")]
		[FieldOffset(Offset = "0x14")]
		internal bool _003ChasdIdleEmotion_003E__0;

		[Token(Token = "0x400C84B")]
		[FieldOffset(Offset = "0x15")]
		internal bool _003CisMoveEmote_003E__0;

		[Token(Token = "0x400C84C")]
		[FieldOffset(Offset = "0x16")]
		internal bool loop;

		[Token(Token = "0x400C84D")]
		[FieldOffset(Offset = "0x17")]
		internal bool playIdleAlternate;

		[Token(Token = "0x400C84E")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Clength_003E__0;

		[Token(Token = "0x400C84F")]
		[FieldOffset(Offset = "0x1C")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C850")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400C851")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400C852")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17000FC4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A065")]
			[Address(RVA = "0x1E6928C", Offset = "0x1E6928C", VA = "0x1E6928C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FC5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A066")]
			[Address(RVA = "0x1E69294", Offset = "0x1E69294", VA = "0x1E69294", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A063")]
		[Address(RVA = "0x1E68A54", Offset = "0x1E68A54", VA = "0x1E68A54")]
		public _003CCoPlayEmotionAnimationd_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600A064")]
		[Address(RVA = "0x1E68A5C", Offset = "0x1E68A5C", VA = "0x1E68A5C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A067")]
		[Address(RVA = "0x1E6929C", Offset = "0x1E6929C", VA = "0x1E6929C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A068")]
		[Address(RVA = "0x1E692B0", Offset = "0x1E692B0", VA = "0x1E692B0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FDA")]
	private sealed class _003CPlayGunCoroutine_003Ec__Iterator4 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C853")]
		[FieldOffset(Offset = "0x8")]
		internal GunType type;

		[Token(Token = "0x400C854")]
		[FieldOffset(Offset = "0xC")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C855")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C856")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C857")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000FC6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A06B")]
			[Address(RVA = "0x1E6A67C", Offset = "0x1E6A67C", VA = "0x1E6A67C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FC7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A06C")]
			[Address(RVA = "0x1E6A684", Offset = "0x1E6A684", VA = "0x1E6A684", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A069")]
		[Address(RVA = "0x1E6A5D8", Offset = "0x1E6A5D8", VA = "0x1E6A5D8")]
		public _003CPlayGunCoroutine_003Ec__Iterator4()
		{
		}

		[Token(Token = "0x600A06A")]
		[Address(RVA = "0x1E6A5E0", Offset = "0x1E6A5E0", VA = "0x1E6A5E0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A06D")]
		[Address(RVA = "0x1E6A68C", Offset = "0x1E6A68C", VA = "0x1E6A68C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A06E")]
		[Address(RVA = "0x1E6A6A0", Offset = "0x1E6A6A0", VA = "0x1E6A6A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FDB")]
	private sealed class _003CSetPlayShowPos_003Ec__Iterator5 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C858")]
		[FieldOffset(Offset = "0x8")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C859")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C85A")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C85B")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FC8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A071")]
			[Address(RVA = "0x1E6AB6C", Offset = "0x1E6AB6C", VA = "0x1E6AB6C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FC9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A072")]
			[Address(RVA = "0x1E6AB74", Offset = "0x1E6AB74", VA = "0x1E6AB74", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A06F")]
		[Address(RVA = "0x1E6A95C", Offset = "0x1E6A95C", VA = "0x1E6A95C")]
		public _003CSetPlayShowPos_003Ec__Iterator5()
		{
		}

		[Token(Token = "0x600A070")]
		[Address(RVA = "0x1E6A964", Offset = "0x1E6A964", VA = "0x1E6A964", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A073")]
		[Address(RVA = "0x1E6AB7C", Offset = "0x1E6AB7C", VA = "0x1E6AB7C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A074")]
		[Address(RVA = "0x1E6AB90", Offset = "0x1E6AB90", VA = "0x1E6AB90", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FDC")]
	private sealed class _003CSetGunAnimTrigger_003Ec__Iterator6 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C85C")]
		[FieldOffset(Offset = "0x8")]
		internal GunType type;

		[Token(Token = "0x400C85D")]
		[FieldOffset(Offset = "0xC")]
		internal string _003CtriggerName_003E__0;

		[Token(Token = "0x400C85E")]
		[FieldOffset(Offset = "0x10")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x400C85F")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C860")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C861")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000FCA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A077")]
			[Address(RVA = "0x1E6A8B0", Offset = "0x1E6A8B0", VA = "0x1E6A8B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FCB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A078")]
			[Address(RVA = "0x1E6A8B8", Offset = "0x1E6A8B8", VA = "0x1E6A8B8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A075")]
		[Address(RVA = "0x1E6A728", Offset = "0x1E6A728", VA = "0x1E6A728")]
		public _003CSetGunAnimTrigger_003Ec__Iterator6()
		{
		}

		[Token(Token = "0x600A076")]
		[Address(RVA = "0x1E6A730", Offset = "0x1E6A730", VA = "0x1E6A730", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A079")]
		[Address(RVA = "0x1E6A8C0", Offset = "0x1E6A8C0", VA = "0x1E6A8C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A07A")]
		[Address(RVA = "0x1E6A8D4", Offset = "0x1E6A8D4", VA = "0x1E6A8D4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FDD")]
	private sealed class _003CShowWeaponNotImmiately_003Ec__AnonStorey7
	{
		[Token(Token = "0x400C862")]
		[FieldOffset(Offset = "0x8")]
		internal bool show;

		[Token(Token = "0x400C863")]
		[FieldOffset(Offset = "0xC")]
		internal UIAnimedAvatar _0024this;

		[Token(Token = "0x600A07B")]
		[Address(RVA = "0x1E6AC18", Offset = "0x1E6AC18", VA = "0x1E6AC18")]
		public _003CShowWeaponNotImmiately_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x600A07C")]
		[Address(RVA = "0x1E6AC20", Offset = "0x1E6AC20", VA = "0x1E6AC20")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600A07D")]
		[Address(RVA = "0x1E6AD8C", Offset = "0x1E6AD8C", VA = "0x1E6AD8C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400C7B1")]
	protected const string IDLE_ANIM_PATTERN = "lobby";

	[Token(Token = "0x400C7B2")]
	protected const string CHANGE_CLOTHES_ANIM_PATTERN = "customanim";

	[Token(Token = "0x400C7B3")]
	protected const float PLAY_IDLE_DELTA_TIME = 3f;

	[Token(Token = "0x400C7B4")]
	protected const float PLAY_EMOTE_IDLE_DELTA_TIME = 7f;

	[Token(Token = "0x400C7B5")]
	[FieldOffset(Offset = "0x78")]
	protected Animator m_PlayerAnimator;

	[Token(Token = "0x400C7B6")]
	[FieldOffset(Offset = "0x7C")]
	protected AvatarPropManager m_AvatarPropManager;

	[Token(Token = "0x400C7B7")]
	[FieldOffset(Offset = "0x80")]
	protected AvatarDynamicEffectManager m_DynamicEffectManager;

	[Token(Token = "0x400C7B8")]
	[FieldOffset(Offset = "0x84")]
	private EmotionManager m_EmotionManager;

	[Token(Token = "0x400C7B9")]
	[FieldOffset(Offset = "0x88")]
	private PropertyData m_CurrentAvatarPropData;

	[Token(Token = "0x400C7BA")]
	[FieldOffset(Offset = "0x8C")]
	private PropertyData m_CurrentClothPropData;

	[Token(Token = "0x400C7BB")]
	[FieldOffset(Offset = "0x90")]
	protected bool m_PlayingShowPose;

	[Token(Token = "0x400C7BC")]
	[FieldOffset(Offset = "0x94")]
	protected float m_ShowPoseTime;

	[Token(Token = "0x400C7BD")]
	[FieldOffset(Offset = "0x98")]
	protected float m_ShowPoseAnimInterval;

	[Token(Token = "0x400C7BE")]
	[FieldOffset(Offset = "0x9C")]
	protected float m_ShowPoseCoolDownSeconds;

	[Token(Token = "0x400C7BF")]
	[FieldOffset(Offset = "0xA0")]
	protected bool m_IsPlayEmoteAnim;

	[Token(Token = "0x400C7C0")]
	[FieldOffset(Offset = "0xA1")]
	protected bool m_IsPlayLobbyEmoteAnim;

	[Token(Token = "0x400C7C1")]
	[FieldOffset(Offset = "0xA4")]
	protected BitArrayBoolean m_IsVisible;

	[Token(Token = "0x400C7C2")]
	public const uint ISVISIBLE_COMMON = 1u;

	[Token(Token = "0x400C7C3")]
	public const uint ISVISIBLE_ANIMATION = 2u;

	[Token(Token = "0x400C7C4")]
	public const uint ISVISIBLE_PREIVEW = 4u;

	[Token(Token = "0x400C7C5")]
	public const uint ISVISIBLE_ANIMATIONEVENT = 8u;

	[Token(Token = "0x400C7C6")]
	public const uint ISVISIBLE_TRANSFORMER = 16u;

	[Token(Token = "0x400C7C7")]
	[FieldOffset(Offset = "0xA8")]
	public Action AvatarCoLobbyFinishedCallback;

	[Token(Token = "0x400C7C8")]
	[FieldOffset(Offset = "0xAC")]
	protected ReplaceAnimData m_ChangeClothesAnim;

	[Token(Token = "0x400C7C9")]
	[FieldOffset(Offset = "0xB0")]
	protected ReplaceAnimData m_IdleAnim;

	[Token(Token = "0x400C7CA")]
	[FieldOffset(Offset = "0xB4")]
	private Dictionary<int, float> m_GunShowTimeDic;

	[Token(Token = "0x400C7CB")]
	[FieldOffset(Offset = "0xB8")]
	private GunType m_UseGunType;

	[Token(Token = "0x400C7CC")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_NeedToPlayGun;

	[Token(Token = "0x400C7CD")]
	[FieldOffset(Offset = "0xC0")]
	private float m_PlayGunTime;

	[Token(Token = "0x400C7CE")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_FirstPlayGunIdle;

	[Token(Token = "0x400C7CF")]
	[FieldOffset(Offset = "0xC8")]
	private float m_ShowGunIdleSeconds;

	[Token(Token = "0x400C7D0")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_PreviewPlayGun;

	[Token(Token = "0x400C7D1")]
	[FieldOffset(Offset = "0xD0")]
	protected ResourceID m_GunResId;

	[Token(Token = "0x400C7D2")]
	[FieldOffset(Offset = "0xD4")]
	protected ResourceID m_GunDefaultResId;

	[Token(Token = "0x400C7D3")]
	[FieldOffset(Offset = "0xD8")]
	private ResourceID m_GunParticleId;

	[Token(Token = "0x400C7D4")]
	[FieldOffset(Offset = "0xDC")]
	private ResourceID m_GunFireEffectId;

	[Token(Token = "0x400C7D5")]
	[FieldOffset(Offset = "0xE0")]
	protected ResourceID m_GunResIdSecond;

	[Token(Token = "0x400C7D6")]
	[FieldOffset(Offset = "0xE4")]
	private MANEMECPKIO m_CollectionResData;

	[Token(Token = "0x400C7D7")]
	[FieldOffset(Offset = "0xE8")]
	private ResourceID m_GunFireSoundId;

	[Token(Token = "0x400C7D8")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_DualWield;

	[Token(Token = "0x400C7D9")]
	[FieldOffset(Offset = "0xED")]
	private bool m_FistUseForeArm;

	[Token(Token = "0x400C7DA")]
	[FieldOffset(Offset = "0xEE")]
	private bool m_DoubleWeapon;

	[Token(Token = "0x400C7DB")]
	[FieldOffset(Offset = "0xF0")]
	protected AnimationClip m_IdleSpecialAnim;

	[Token(Token = "0x400C7DC")]
	[FieldOffset(Offset = "0xF4")]
	private ResourceID m_AnimResCtrl;

	[Token(Token = "0x400C7DD")]
	[FieldOffset(Offset = "0xF8")]
	private uint m_delayCallShowWeapon;

	[Token(Token = "0x400C7DE")]
	[FieldOffset(Offset = "0xFC")]
	protected AvatarAbInfos m_AvatarAbInfos;

	[Token(Token = "0x400C7DF")]
	[FieldOffset(Offset = "0x100")]
	protected float m_PlayIdleTime;

	[Token(Token = "0x400C7E0")]
	[FieldOffset(Offset = "0x104")]
	protected bool m_CanRecordIdle;

	[Token(Token = "0x400C7E1")]
	[FieldOffset(Offset = "0x105")]
	protected bool m_CanPlaySpecialIdle;

	[Token(Token = "0x400C7E2")]
	[FieldOffset(Offset = "0x106")]
	protected bool m_RealPlaySpecialIdle;

	[Token(Token = "0x400C7E3")]
	[FieldOffset(Offset = "0x108")]
	protected float m_PlayIdleDeltaTime;

	[Token(Token = "0x400C7E4")]
	[FieldOffset(Offset = "0x10C")]
	protected bool m_CanPlayIdleAlternative;

	[Token(Token = "0x400C7E5")]
	[FieldOffset(Offset = "0x10D")]
	protected bool m_RealPlayIdleAlternative;

	[Token(Token = "0x400C7E6")]
	[FieldOffset(Offset = "0x10E")]
	protected bool m_RootScaleAndSkinEnabled;

	[Token(Token = "0x400C7E7")]
	[FieldOffset(Offset = "0x10F")]
	protected bool m_ForceChangeRace;

	[Token(Token = "0x400C7E8")]
	[FieldOffset(Offset = "0x110")]
	private bool m_IsDoubleAnim;

	[Token(Token = "0x400C7E9")]
	[FieldOffset(Offset = "0x111")]
	private bool m_IsRecycleProp;

	[Token(Token = "0x400C7EA")]
	[FieldOffset(Offset = "0x112")]
	private bool m_SkipSpecailAnim;

	[Token(Token = "0x400C7EB")]
	[FieldOffset(Offset = "0x114")]
	private float m_RandomSpeicalIdleTime;

	[Token(Token = "0x400C7EC")]
	[FieldOffset(Offset = "0x118")]
	protected bool m_IsSkipCustom;

	[Token(Token = "0x400C7ED")]
	[FieldOffset(Offset = "0x119")]
	protected bool m_IsAvatarReady;

	[Token(Token = "0x400C7EE")]
	[FieldOffset(Offset = "0x11C")]
	private float m_AvatarPosY;

	[Token(Token = "0x400C7EF")]
	[FieldOffset(Offset = "0x120")]
	private BattleFlagConfigData m_BattleFlagConfigData;

	[Token(Token = "0x400C7F0")]
	[FieldOffset(Offset = "0x124")]
	protected GameObject m_OneShotObj;

	[Token(Token = "0x400C7F1")]
	[FieldOffset(Offset = "0x128")]
	public GameObject LightObj;

	[Token(Token = "0x400C7F2")]
	[FieldOffset(Offset = "0x12C")]
	private Transform m_characterRoot;

	[Token(Token = "0x400C7F3")]
	[FieldOffset(Offset = "0x130")]
	private uint m_GroupEmotionEffIdx;

	[Token(Token = "0x400C7F4")]
	[FieldOffset(Offset = "0x134")]
	private bool m_DoNotCallUpdateCallack;

	[Token(Token = "0x400C7F5")]
	[FieldOffset(Offset = "0x138")]
	protected GameObject m_backpack;

	[Token(Token = "0x400C7F6")]
	[FieldOffset(Offset = "0x13C")]
	private uint _003CEmoteID_003Ek__BackingField;

	[Token(Token = "0x400C7F7")]
	[FieldOffset(Offset = "0x140")]
	private int m_EmoteSoundTicket;

	[Token(Token = "0x400C7F8")]
	[FieldOffset(Offset = "0x144")]
	private bool _003CUsingClothProp_003Ek__BackingField;

	[Token(Token = "0x400C7F9")]
	[FieldOffset(Offset = "0x145")]
	private bool m_UsingAvatarProp;

	[Token(Token = "0x400C7FA")]
	[FieldOffset(Offset = "0x148")]
	protected uint UMAMaterialAnimPackBagID;

	[Token(Token = "0x400C7FB")]
	[FieldOffset(Offset = "0x14C")]
	protected uint UMAMaterialAnimPackBagLevel;

	[Token(Token = "0x400C7FC")]
	[FieldOffset(Offset = "0x150")]
	private GameObject m_transformerAvatar;

	[Token(Token = "0x400C7FD")]
	[FieldOffset(Offset = "0x154")]
	private IEnumerator playEmontionAnimCor;

	[Token(Token = "0x400C7FE")]
	[FieldOffset(Offset = "0x158")]
	private bool _003CIsWeaponIdleAnimReplaced_003Ek__BackingField;

	[Token(Token = "0x400C7FF")]
	[FieldOffset(Offset = "0x15C")]
	protected AnimationClip CachedIdleAnimClip;

	[Token(Token = "0x400C800")]
	[FieldOffset(Offset = "0x160")]
	private Dictionary<Transform, TransCache> m_TmpDynamicBones;

	[Token(Token = "0x400C801")]
	[FieldOffset(Offset = "0x164")]
	private string doubleSpecialanim;

	[Token(Token = "0x400C802")]
	[FieldOffset(Offset = "0x168")]
	private string doubleIdleanim;

	[Token(Token = "0x400C803")]
	[FieldOffset(Offset = "0x16C")]
	private LobbyAvatarLookAtComponent m_LookAtComponent;

	[Token(Token = "0x400C804")]
	[FieldOffset(Offset = "0x170")]
	private bool canShowWeapon;

	[Token(Token = "0x400C805")]
	[FieldOffset(Offset = "0x171")]
	private bool m_DynamicBonesActive;

	[Token(Token = "0x400C806")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C807")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400C808")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400C809")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400C80A")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400C80B")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x400C80C")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x400C80D")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x400C80E")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x17000FB4")]
	public bool RealPlaySpecialIdle
	{
		[Token(Token = "0x6009F76")]
		[Address(RVA = "0x1F32C40", Offset = "0x1F32C40", VA = "0x1F32C40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000FB5")]
	public bool ForceChangeRace
	{
		[Token(Token = "0x6009F77")]
		[Address(RVA = "0x1F32C98", Offset = "0x1F32C98", VA = "0x1F32C98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009F78")]
		[Address(RVA = "0x1F32CF0", Offset = "0x1F32CF0", VA = "0x1F32CF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000FB6")]
	public uint GroupEmotionEffIdx
	{
		[Token(Token = "0x6009F7A")]
		[Address(RVA = "0x1F32E70", Offset = "0x1F32E70", VA = "0x1F32E70")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000FB7")]
	public bool DoNotCallUpdateCallback
	{
		[Token(Token = "0x6009F7B")]
		[Address(RVA = "0x1F32EC8", Offset = "0x1F32EC8", VA = "0x1F32EC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009F7C")]
		[Address(RVA = "0x1F32F20", Offset = "0x1F32F20", VA = "0x1F32F20")]
		set
		{
		}
	}

	[Token(Token = "0x17000FB8")]
	public uint EmoteID
	{
		[Token(Token = "0x6009F7D")]
		[Address(RVA = "0x1F32F80", Offset = "0x1F32F80", VA = "0x1F32F80")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6009F7E")]
		[Address(RVA = "0x1F32F88", Offset = "0x1F32F88", VA = "0x1F32F88")]
		set
		{
		}
	}

	[Token(Token = "0x17000FB9")]
	public bool UsingClothProp
	{
		[Token(Token = "0x6009F7F")]
		[Address(RVA = "0x1F32F90", Offset = "0x1F32F90", VA = "0x1F32F90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009F80")]
		[Address(RVA = "0x1F32F98", Offset = "0x1F32F98", VA = "0x1F32F98")]
		set
		{
		}
	}

	[Token(Token = "0x17000FBA")]
	public bool UsingAvatarProp
	{
		[Token(Token = "0x6009F81")]
		[Address(RVA = "0x1F32FA0", Offset = "0x1F32FA0", VA = "0x1F32FA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009F82")]
		[Address(RVA = "0x1F32FF8", Offset = "0x1F32FF8", VA = "0x1F32FF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000FBB")]
	public Animator PlayerAnimator
	{
		[Token(Token = "0x6009F86")]
		[Address(RVA = "0x1F333B4", Offset = "0x1F333B4", VA = "0x1F333B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FBC")]
	private bool IsIdleAnimReplaced
	{
		[Token(Token = "0x6009FC6")]
		[Address(RVA = "0x1F3917C", Offset = "0x1F3917C", VA = "0x1F3917C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000FBD")]
	public bool IsWeaponIdleAnimReplaced
	{
		[Token(Token = "0x6009FC7")]
		[Address(RVA = "0x1F3ACB0", Offset = "0x1F3ACB0", VA = "0x1F3ACB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009FC8")]
		[Address(RVA = "0x1F3ACB8", Offset = "0x1F3ACB8", VA = "0x1F3ACB8")]
		set
		{
		}
	}

	[Token(Token = "0x6009F75")]
	[Address(RVA = "0x1F32A6C", Offset = "0x1F32A6C", VA = "0x1F32A6C")]
	public UIAnimedAvatar()
	{
	}

	[Token(Token = "0x6009F79")]
	[Address(RVA = "0x1F32D50", Offset = "0x1F32D50", VA = "0x1F32D50")]
	protected Transform GetCharacterRoot()
	{
		return null;
	}

	[Token(Token = "0x6009F83")]
	[Address(RVA = "0x1F33058", Offset = "0x1F33058", VA = "0x1F33058")]
	public bool GetAvatarReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F84")]
	[Address(RVA = "0x1F330C8", Offset = "0x1F330C8", VA = "0x1F330C8")]
	public bool GetCollectionBackpackReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F85")]
	[Address(RVA = "0x1F33138", Offset = "0x1F33138", VA = "0x1F33138")]
	public bool CHeckNoDiffFromClothes(Dictionary<uint, bool> temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F87")]
	[Address(RVA = "0x1F3340C", Offset = "0x1F3340C", VA = "0x1F3340C", Slot = "24")]
	public override void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1)
	{
	}

	[Token(Token = "0x6009F88")]
	[Address(RVA = "0x1F3353C", Offset = "0x1F3353C", VA = "0x1F3353C", Slot = "28")]
	protected override void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	[Token(Token = "0x6009F89")]
	[Address(RVA = "0x1F33A10", Offset = "0x1F33A10", VA = "0x1F33A10")]
	private void SetUpDynamicEffect()
	{
	}

	[Token(Token = "0x6009F8A")]
	[Address(RVA = "0x1F33B20", Offset = "0x1F33B20", VA = "0x1F33B20")]
	private void ResetAnims()
	{
	}

	[Token(Token = "0x6009F8B")]
	[Address(RVA = "0x1F34080", Offset = "0x1F34080", VA = "0x1F34080", Slot = "37")]
	protected override void OnSetAvatarDone(CSSharedAvatarData aData)
	{
	}

	[Token(Token = "0x6009F8C")]
	[Address(RVA = "0x1F3463C", Offset = "0x1F3463C", VA = "0x1F3463C", Slot = "33")]
	protected override void ChangeRace(string race)
	{
	}

	[Token(Token = "0x6009F8D")]
	[Address(RVA = "0x1F3420C", Offset = "0x1F3420C", VA = "0x1F3420C")]
	public void UpdatePropItem()
	{
	}

	[Token(Token = "0x6009F8E")]
	[Address(RVA = "0x1F346C0", Offset = "0x1F346C0", VA = "0x1F346C0")]
	public bool CheckAvatarHasWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F8F")]
	[Address(RVA = "0x1F34734", Offset = "0x1F34734", VA = "0x1F34734")]
	protected void Update()
	{
	}

	[Token(Token = "0x6009F90")]
	[Address(RVA = "0x1F34A78", Offset = "0x1F34A78", VA = "0x1F34A78", Slot = "39")]
	protected virtual void DoUpdate()
	{
	}

	[Token(Token = "0x6009F91")]
	[Address(RVA = "0x1F34FF4", Offset = "0x1F34FF4", VA = "0x1F34FF4", Slot = "38")]
	public override void ResetAvatar()
	{
	}

	[Token(Token = "0x6009F92")]
	[Address(RVA = "0x1F3577C", Offset = "0x1F3577C", VA = "0x1F3577C")]
	public void ResetWeaponShow()
	{
	}

	[Token(Token = "0x6009F93")]
	[Address(RVA = "0x1F358AC", Offset = "0x1F358AC", VA = "0x1F358AC")]
	public void UpdateLobbyBackPackSlot(uint backpackid, uint level)
	{
	}

	[Token(Token = "0x6009F94")]
	[Address(RVA = "0x1F36AAC", Offset = "0x1F36AAC", VA = "0x1F36AAC")]
	public void ClearBackpack()
	{
	}

	[Token(Token = "0x6009F95")]
	[Address(RVA = "0x1F367BC", Offset = "0x1F367BC", VA = "0x1F367BC")]
	protected void DestroyBackpack()
	{
	}

	[Token(Token = "0x6009F96")]
	[Address(RVA = "0x1F36BF8", Offset = "0x1F36BF8", VA = "0x1F36BF8")]
	public void ForceUpdateBackPackUma()
	{
	}

	[Token(Token = "0x6009F97")]
	[Address(RVA = "0x1F3565C", Offset = "0x1F3565C", VA = "0x1F3565C")]
	public void ClearBackPackSlot()
	{
	}

	[Token(Token = "0x6009F98")]
	[Address(RVA = "0x1F36D74", Offset = "0x1F36D74", VA = "0x1F36D74")]
	public void ClearBackPackPrefab()
	{
	}

	[Token(Token = "0x6009F99")]
	[Address(RVA = "0x1F36924", Offset = "0x1F36924", VA = "0x1F36924")]
	protected void ProcessPackbagMaterialAnimEffect(uint itemID, uint level)
	{
	}

	[Token(Token = "0x6009F9A")]
	[Address(RVA = "0x1F36C64", Offset = "0x1F36C64", VA = "0x1F36C64")]
	protected void CleanPackbagMaterialAnimEffect()
	{
	}

	[Token(Token = "0x6009F9B")]
	[Address(RVA = "0x1F36EA0", Offset = "0x1F36EA0", VA = "0x1F36EA0")]
	protected void LoadMaterialAnimEffect(uint itemID, int type, uint level)
	{
	}

	[Token(Token = "0x6009F9C")]
	[Address(RVA = "0x1F372B4", Offset = "0x1F372B4", VA = "0x1F372B4")]
	public bool CheckLobbyEmoteAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F9D")]
	[Address(RVA = "0x1F3730C", Offset = "0x1F3730C", VA = "0x1F3730C")]
	public void SetAvatar(UIMaleAvatar avatar)
	{
	}

	[Token(Token = "0x6009F9E")]
	[Address(RVA = "0x1F3743C", Offset = "0x1F3743C", VA = "0x1F3743C")]
	public void PlayAnimClipAtLobby(ResourceID resId, bool needdelayshow = false, bool loop = false, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x6009F9F")]
	[Address(RVA = "0x1F37CA0", Offset = "0x1F37CA0", VA = "0x1F37CA0")]
	public void RegisterCoAtLobbyCallback(Action callback)
	{
	}

	[Token(Token = "0x6009FA0")]
	[Address(RVA = "0x1F37F7C", Offset = "0x1F37F7C", VA = "0x1F37F7C")]
	public void StartUpdateLobbyBackPackSlot(uint id, uint level)
	{
	}

	[Token(Token = "0x6009FA1")]
	[Address(RVA = "0x1F38014", Offset = "0x1F38014", VA = "0x1F38014")]
	private IEnumerator UpdateDoBackpackUpdate(uint id, uint level)
	{
		return null;
	}

	[Token(Token = "0x6009FA2")]
	[Address(RVA = "0x1F37E50", Offset = "0x1F37E50", VA = "0x1F37E50")]
	private IEnumerator CoPlayAnimClipAtLobby(ResourceID resId, bool loop = false, bool playIdleAlternate = false)
	{
		return null;
	}

	[Token(Token = "0x6009FA3")]
	[Address(RVA = "0x1F3812C", Offset = "0x1F3812C", VA = "0x1F3812C")]
	public void PlayTransformerAtLobby(TransformData data, bool loop = true)
	{
	}

	[Token(Token = "0x6009FA4")]
	[Address(RVA = "0x1F38200", Offset = "0x1F38200", VA = "0x1F38200")]
	private IEnumerator CoPlayTransformerAtLobby(TransformData data, bool loop)
	{
		return null;
	}

	[Token(Token = "0x6009FA5")]
	[Address(RVA = "0x1F38318", Offset = "0x1F38318", VA = "0x1F38318")]
	public void PlayEmotionAnimation(uint emotionID, bool loop = false, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x6009FA6")]
	[Address(RVA = "0x1F37D00", Offset = "0x1F37D00", VA = "0x1F37D00")]
	protected void CleanLastAnimLegacy()
	{
	}

	[Token(Token = "0x6009FA7")]
	[Address(RVA = "0x1F38510", Offset = "0x1F38510", VA = "0x1F38510")]
	private IEnumerator CoPlayEmotionAnimationd(uint emotionID, bool loop = false, bool playIdleAlternate = false)
	{
		return null;
	}

	[Token(Token = "0x6009FA8")]
	[Address(RVA = "0x1F38750", Offset = "0x1F38750", VA = "0x1F38750")]
	public void PlayEmoteBGM(ResourceID resourceID, bool loop)
	{
	}

	[Token(Token = "0x6009FA9")]
	[Address(RVA = "0x1F389A8", Offset = "0x1F389A8", VA = "0x1F389A8")]
	public void StopEmoteBGM()
	{
	}

	[Token(Token = "0x6009FAA")]
	[Address(RVA = "0x1F38B48", Offset = "0x1F38B48", VA = "0x1F38B48")]
	public void SetActive(bool isShow)
	{
	}

	[Token(Token = "0x6009FAB")]
	[Address(RVA = "0x1F38BF0", Offset = "0x1F38BF0", VA = "0x1F38BF0")]
	public bool GetIsPlayEmotion()
	{
		return default(bool);
	}

	[Token(Token = "0x6009FAC")]
	[Address(RVA = "0x1F38C48", Offset = "0x1F38C48", VA = "0x1F38C48")]
	public bool GetFistUseForeArm()
	{
		return default(bool);
	}

	[Token(Token = "0x6009FAD")]
	[Address(RVA = "0x1F375A0", Offset = "0x1F375A0", VA = "0x1F375A0")]
	public void StopPlayEmotionAnim()
	{
	}

	[Token(Token = "0x6009FAE")]
	[Address(RVA = "0x1F33F94", Offset = "0x1F33F94", VA = "0x1F33F94")]
	private IEnumerator PlayGunCoroutine(GunType type)
	{
		return null;
	}

	[Token(Token = "0x6009FAF")]
	[Address(RVA = "0x1F38CA0", Offset = "0x1F38CA0", VA = "0x1F38CA0")]
	public void SetGroupEmotionEffIdx(uint idx)
	{
	}

	[Token(Token = "0x6009FB0")]
	[Address(RVA = "0x1F38D00", Offset = "0x1F38D00", VA = "0x1F38D00")]
	public void StopEmotionAndRebuildWeapon()
	{
	}

	[Token(Token = "0x6009FB1")]
	[Address(RVA = "0x1F38D74", Offset = "0x1F38D74", VA = "0x1F38D74")]
	public void StopEmotionAnimation()
	{
	}

	[Token(Token = "0x6009FB2")]
	[Address(RVA = "0x1F38EDC", Offset = "0x1F38EDC", VA = "0x1F38EDC")]
	public void SuspendEmotionAnimation()
	{
	}

	[Token(Token = "0x6009FB3")]
	[Address(RVA = "0x1F38E10", Offset = "0x1F38E10", VA = "0x1F38E10")]
	private void EnsureMotionManager()
	{
	}

	[Token(Token = "0x6009FB4")]
	[Address(RVA = "0x1F38F6C", Offset = "0x1F38F6C", VA = "0x1F38F6C")]
	protected void SetTrigger(string s)
	{
	}

	[Token(Token = "0x6009FB5")]
	[Address(RVA = "0x1F39074", Offset = "0x1F39074", VA = "0x1F39074")]
	protected void ResetTrigger(string s)
	{
	}

	[Token(Token = "0x6009FB6")]
	[Address(RVA = "0x1F34BF8", Offset = "0x1F34BF8", VA = "0x1F34BF8")]
	private void UpdateShowPoseAnim()
	{
	}

	[Token(Token = "0x6009FB7")]
	[Address(RVA = "0x1F392E4", Offset = "0x1F392E4", VA = "0x1F392E4")]
	public void SetSpecialIdeEnabled(bool flag)
	{
	}

	[Token(Token = "0x6009FB8")]
	[Address(RVA = "0x1F34CB0", Offset = "0x1F34CB0", VA = "0x1F34CB0")]
	private void UpdateSpecialIdleAnim()
	{
	}

	[Token(Token = "0x6009FB9")]
	[Address(RVA = "0x1F34F34", Offset = "0x1F34F34", VA = "0x1F34F34")]
	private void UpdatePlayIdleAlternativeAnim()
	{
	}

	[Token(Token = "0x6009FBA")]
	[Address(RVA = "0x1F39910", Offset = "0x1F39910", VA = "0x1F39910")]
	public bool GetIsRecylceProp()
	{
		return default(bool);
	}

	[Token(Token = "0x6009FBB")]
	[Address(RVA = "0x1F39768", Offset = "0x1F39768", VA = "0x1F39768")]
	public void SetRecycleProp(bool flag)
	{
	}

	[Token(Token = "0x6009FBC")]
	[Address(RVA = "0x1F391F4", Offset = "0x1F391F4", VA = "0x1F391F4")]
	private void PlayShowPoseAnim()
	{
	}

	[Token(Token = "0x6009FBD")]
	[Address(RVA = "0x1F39968", Offset = "0x1F39968", VA = "0x1F39968")]
	private void ForcePlayShowPoseAnim()
	{
	}

	[Token(Token = "0x6009FBE")]
	[Address(RVA = "0x1F39A20", Offset = "0x1F39A20", VA = "0x1F39A20")]
	private IEnumerator SetPlayShowPos()
	{
		return null;
	}

	[Token(Token = "0x6009FBF")]
	[Address(RVA = "0x1F33E9C", Offset = "0x1F33E9C", VA = "0x1F33E9C")]
	private void StopShowPoseAnim(bool cleareffect = true)
	{
	}

	[Token(Token = "0x6009FC0")]
	[Address(RVA = "0x1F39AEC", Offset = "0x1F39AEC", VA = "0x1F39AEC", Slot = "40")]
	public virtual void StartShowPose()
	{
	}

	[Token(Token = "0x6009FC1")]
	[Address(RVA = "0x1F3A334", Offset = "0x1F3A334", VA = "0x1F3A334")]
	public void ForceStartShowPose()
	{
	}

	[Token(Token = "0x6009FC2")]
	[Address(RVA = "0x1F3A3A8", Offset = "0x1F3A3A8", VA = "0x1F3A3A8")]
	public void UpdateWeaponOnHand(uint skinID)
	{
	}

	[Token(Token = "0x6009FC3")]
	[Address(RVA = "0x1F3A680", Offset = "0x1F3A680", VA = "0x1F3A680")]
	private bool IsDualWeild(WeaponSkinData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6009FC4")]
	[Address(RVA = "0x1F3AC38", Offset = "0x1F3AC38", VA = "0x1F3AC38", Slot = "41")]
	public virtual void StopShowPose(bool cleareffect = true)
	{
	}

	[Token(Token = "0x6009FC5")]
	[Address(RVA = "0x1F39F54", Offset = "0x1F39F54", VA = "0x1F39F54")]
	protected void SetShowPosing(bool b)
	{
	}

	[Token(Token = "0x6009FC9")]
	[Address(RVA = "0x1F3ACC0", Offset = "0x1F3ACC0", VA = "0x1F3ACC0")]
	public bool IsShowSpecialIdle()
	{
		return default(bool);
	}

	[Token(Token = "0x6009FCA")]
	[Address(RVA = "0x1F33BD0", Offset = "0x1F33BD0", VA = "0x1F33BD0")]
	private void UpdateClothesChangeAnim()
	{
	}

	[Token(Token = "0x6009FCB")]
	[Address(RVA = "0x1F33E2C", Offset = "0x1F33E2C", VA = "0x1F33E2C")]
	private void TryPlayPreviewAvatarAnimation()
	{
	}

	[Token(Token = "0x6009FCC")]
	[Address(RVA = "0x1F3B8C8", Offset = "0x1F3B8C8", VA = "0x1F3B8C8")]
	private void PlayPreviewPose()
	{
	}

	[Token(Token = "0x6009FCD")]
	[Address(RVA = "0x1F39E24", Offset = "0x1F39E24", VA = "0x1F39E24")]
	private bool IsSpecialPreviewOnlyAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x6009FCE")]
	[Address(RVA = "0x1F3AF74", Offset = "0x1F3AF74", VA = "0x1F3AF74")]
	private void OverrideClothesAnim(ReplaceAnimData data, bool changeClothes)
	{
	}

	[Token(Token = "0x6009FCF")]
	[Address(RVA = "0x1F3C0FC", Offset = "0x1F3C0FC", VA = "0x1F3C0FC")]
	private void OverrideClothesAnim(ResourceID id, bool changeAnim)
	{
	}

	[Token(Token = "0x6009FD0")]
	[Address(RVA = "0x1F3BA30", Offset = "0x1F3BA30", VA = "0x1F3BA30")]
	private void OverrideClothesAnim(AnimationClip clip, bool changeAnim)
	{
	}

	[Token(Token = "0x6009FD1")]
	[Address(RVA = "0x1F3CA5C", Offset = "0x1F3CA5C", VA = "0x1F3CA5C")]
	protected void ResetOverrideWeaponIdleAnim()
	{
	}

	[Token(Token = "0x6009FD2")]
	[Address(RVA = "0x1F3BAEC", Offset = "0x1F3BAEC", VA = "0x1F3BAEC")]
	private AnimationClip GetClothesAnimClip(bool baseClip, bool changeAnim)
	{
		return null;
	}

	[Token(Token = "0x6009FD3")]
	[Address(RVA = "0x1F397C8", Offset = "0x1F397C8", VA = "0x1F397C8")]
	private void PlayClothesChangeAnim()
	{
	}

	[Token(Token = "0x6009FD4")]
	[Address(RVA = "0x1F3CD60", Offset = "0x1F3CD60", VA = "0x1F3CD60")]
	private void StopClothesChangeAnim(bool cleareffect = true)
	{
	}

	[Token(Token = "0x6009FD5")]
	[Address(RVA = "0x1F3CEF4", Offset = "0x1F3CEF4", VA = "0x1F3CEF4")]
	public void PlayCustomAnim(ResourceID rid)
	{
	}

	[Token(Token = "0x6009FD6")]
	[Address(RVA = "0x1F3D16C", Offset = "0x1F3D16C", VA = "0x1F3D16C")]
	public void ReplaceAnimByName(ResourceID rid, string name)
	{
	}

	[Token(Token = "0x6009FD7")]
	[Address(RVA = "0x1F3D3EC", Offset = "0x1F3D3EC", VA = "0x1F3D3EC")]
	public void SetSkipCustomParm(bool flag)
	{
	}

	[Token(Token = "0x6009FD8")]
	[Address(RVA = "0x1F3D44C", Offset = "0x1F3D44C", VA = "0x1F3D44C")]
	public void StopAvatarAnim(bool cleareffect)
	{
	}

	[Token(Token = "0x6009FD9")]
	[Address(RVA = "0x1F3D828", Offset = "0x1F3D828", VA = "0x1F3D828")]
	public ResourceID GetClothesChangeAnim(AvatarWardrobeData aData)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009FDA")]
	[Address(RVA = "0x1F3D914", Offset = "0x1F3D914", VA = "0x1F3D914")]
	public ResourceID GetClothesIdleAnim(AvatarWardrobeData aData)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009FDB")]
	[Address(RVA = "0x1F3DA00", Offset = "0x1F3DA00", VA = "0x1F3DA00")]
	public void PlayClothesAnims(uint wId, bool playChangeAnim, bool playIdleAnim, bool waitDirty = true, bool playIdleAlternative = false)
	{
	}

	[Token(Token = "0x6009FDC")]
	[Address(RVA = "0x1F3DBC0", Offset = "0x1F3DBC0", VA = "0x1F3DBC0")]
	internal bool PlayClothesAnims(AvatarWardrobeData aData, bool playChangeAnim, bool playIdleAnim, bool playIdleAlternative = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6009FDD")]
	[Address(RVA = "0x1F3DF74", Offset = "0x1F3DF74", VA = "0x1F3DF74")]
	public void PlayFacialAnim(uint wId)
	{
	}

	[Token(Token = "0x6009FDE")]
	[Address(RVA = "0x1F3DFFC", Offset = "0x1F3DFFC", VA = "0x1F3DFFC")]
	public void PlayFacialAnim(AvatarWardrobeData wData)
	{
	}

	[Token(Token = "0x6009FDF")]
	[Address(RVA = "0x1F3E074", Offset = "0x1F3E074", VA = "0x1F3E074")]
	public void PlayFacialAnim(UIModelAvatarBase.EWardrobeType wType = UIModelAvatarBase.EWardrobeType.CLOTHESTYPENONE)
	{
	}

	[Token(Token = "0x6009FE0")]
	[Address(RVA = "0x1F3DDE8", Offset = "0x1F3DDE8", VA = "0x1F3DDE8")]
	protected bool PlayClothesChangeAnim(ResourceID resId, ResourceID effectID)
	{
		return default(bool);
	}

	[Token(Token = "0x6009FE1")]
	[Address(RVA = "0x1F3DE74", Offset = "0x1F3DE74", VA = "0x1F3DE74")]
	protected bool PlayClothesIdleAnim(ResourceID resId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009FE2")]
	[Address(RVA = "0x1F3D590", Offset = "0x1F3D590", VA = "0x1F3D590")]
	protected bool CheckAndOverrideAnim(ReplaceAnimData data, ResourceID id, ResourceID effectID)
	{
		return default(bool);
	}

	[Token(Token = "0x6009FE3")]
	[Address(RVA = "0x1F352EC", Offset = "0x1F352EC", VA = "0x1F352EC")]
	internal void StopClothesChangeAnims()
	{
	}

	[Token(Token = "0x6009FE4")]
	[Address(RVA = "0x1F342E0", Offset = "0x1F342E0", VA = "0x1F342E0")]
	protected void ResetClothesDefaultAnims()
	{
	}

	[Token(Token = "0x6009FE5")]
	[Address(RVA = "0x1F3E2C8", Offset = "0x1F3E2C8", VA = "0x1F3E2C8")]
	protected void ResetClothesOverrideAnims()
	{
	}

	[Token(Token = "0x6009FE6")]
	[Address(RVA = "0x1F34AF8", Offset = "0x1F34AF8", VA = "0x1F34AF8")]
	private void UpdateGunAnimation()
	{
	}

	[Token(Token = "0x6009FE7")]
	[Address(RVA = "0x1F3E360", Offset = "0x1F3E360", VA = "0x1F3E360")]
	private void PlayGunAnimation(GunType type)
	{
	}

	[Token(Token = "0x6009FE8")]
	[Address(RVA = "0x1F3E6C4", Offset = "0x1F3E6C4", VA = "0x1F3E6C4")]
	public void UpdateRuntimeAnimController(CSSharedAvatarData aData, bool female)
	{
	}

	[Token(Token = "0x6009FE9")]
	[Address(RVA = "0x1F3EB18", Offset = "0x1F3EB18", VA = "0x1F3EB18")]
	public void ResetRunTimeAnimController()
	{
	}

	[Token(Token = "0x6009FEA")]
	[Address(RVA = "0x1F3E418", Offset = "0x1F3E418", VA = "0x1F3E418")]
	private ResourceID GetIdleAnimResByGunType(GunType type)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009FEB")]
	[Address(RVA = "0x1F3ED3C", Offset = "0x1F3ED3C", VA = "0x1F3ED3C")]
	private void ForcePlayAnim(GunType type)
	{
	}

	[Token(Token = "0x6009FEC")]
	[Address(RVA = "0x1F3E5D8", Offset = "0x1F3E5D8", VA = "0x1F3E5D8")]
	private IEnumerator SetGunAnimTrigger(GunType type)
	{
		return null;
	}

	[Token(Token = "0x6009FED")]
	[Address(RVA = "0x1F3F6DC", Offset = "0x1F3F6DC", VA = "0x1F3F6DC")]
	private void ResetAvatarOtherAnim()
	{
	}

	[Token(Token = "0x6009FEE")]
	[Address(RVA = "0x1F3F498", Offset = "0x1F3F498", VA = "0x1F3F498")]
	protected string GetGunAnimTriggerName(GunType type)
	{
		return null;
	}

	[Token(Token = "0x6009FEF")]
	[Address(RVA = "0x1F3F7D0", Offset = "0x1F3F7D0", VA = "0x1F3F7D0")]
	public void StartShowAvatar()
	{
	}

	[Token(Token = "0x6009FF0")]
	[Address(RVA = "0x1F3F824", Offset = "0x1F3F824", VA = "0x1F3F824")]
	public void SetRootFlagAndSkinEnabled(bool flag)
	{
	}

	[Token(Token = "0x6009FF1")]
	[Address(RVA = "0x1F3F8A4", Offset = "0x1F3F8A4", VA = "0x1F3F8A4")]
	public void ForceSetRootFlagAndSkinEnabled(bool flag)
	{
	}

	[Token(Token = "0x6009FF2")]
	[Address(RVA = "0x1F3F918", Offset = "0x1F3F918", VA = "0x1F3F918")]
	public void ResetAvatarReady()
	{
	}

	[Token(Token = "0x6009FF3")]
	[Address(RVA = "0x1F3F974", Offset = "0x1F3F974", VA = "0x1F3F974")]
	public void PlayDoubleSpecialAnim(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6009FF4")]
	[Address(RVA = "0x1F3FEA4", Offset = "0x1F3FEA4", VA = "0x1F3FEA4")]
	public void SetSkipAnimParm(bool flag)
	{
	}

	[Token(Token = "0x6009FF5")]
	[Address(RVA = "0x1F3FF04", Offset = "0x1F3FF04", VA = "0x1F3FF04")]
	public void SaveAvatarPosY()
	{
	}

	[Token(Token = "0x6009FF6")]
	[Address(RVA = "0x1F3FFA0", Offset = "0x1F3FFA0", VA = "0x1F3FFA0")]
	public void ShowProfileHideOrShow(bool flag)
	{
	}

	[Token(Token = "0x6009FF7")]
	[Address(RVA = "0x1F40210", Offset = "0x1F40210", VA = "0x1F40210")]
	public void SetCharcterRootAndSkinVisble(bool enabled)
	{
	}

	[Token(Token = "0x6009FF8")]
	[Address(RVA = "0x1F406E4", Offset = "0x1F406E4", VA = "0x1F406E4")]
	public void InitAvatarVisibleState()
	{
	}

	[Token(Token = "0x6009FF9")]
	[Address(RVA = "0x1F40758", Offset = "0x1F40758", VA = "0x1F40758")]
	public bool IsSkinnedRendererActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6009FFA")]
	[Address(RVA = "0x1F37708", Offset = "0x1F37708", VA = "0x1F37708")]
	public void SetCharcterRootScaleAndSkinVisble(bool bVisible, uint flag = 1u)
	{
	}

	[Token(Token = "0x6009FFB")]
	[Address(RVA = "0x1F40A88", Offset = "0x1F40A88", VA = "0x1F40A88")]
	public void ShowWeaponNotImmiately(bool show = true)
	{
	}

	[Token(Token = "0x6009FFC")]
	[Address(RVA = "0x1F3A83C", Offset = "0x1F3A83C", VA = "0x1F3A83C")]
	public void ShowWeapon(bool show = true)
	{
	}

	[Token(Token = "0x6009FFD")]
	[Address(RVA = "0x1F3A6FC", Offset = "0x1F3A6FC", VA = "0x1F3A6FC")]
	public void PlayWithGun(MANEMECPKIO data, ResourceID defaultid, bool rebind = true, bool dualWeild = false)
	{
	}

	[Token(Token = "0x6009FFE")]
	[Address(RVA = "0x1F41468", Offset = "0x1F41468", VA = "0x1F41468")]
	public MANEMECPKIO GetCollectionResData()
	{
		return null;
	}

	[Token(Token = "0x6009FFF")]
	[Address(RVA = "0x1F40C68", Offset = "0x1F40C68", VA = "0x1F40C68")]
	public void PlayWithGun(MANEMECPKIO data, ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weaponfiresoundid, ResourceID weapondefaultid, bool rebind = true, bool dualWeild = false)
	{
	}

	[Token(Token = "0x600A000")]
	[Address(RVA = "0x1F39FB4", Offset = "0x1F39FB4", VA = "0x1F39FB4")]
	public AnimationClip[] GetAnimaitionclips()
	{
		return null;
	}

	[Token(Token = "0x600A001")]
	[Address(RVA = "0x1F414C0", Offset = "0x1F414C0", VA = "0x1F414C0")]
	private void InitGunShowTime()
	{
	}

	[Token(Token = "0x600A002")]
	[Address(RVA = "0x1F42380", Offset = "0x1F42380", VA = "0x1F42380")]
	public void PlayFireEffect(bool right)
	{
	}

	[Token(Token = "0x600A003")]
	[Address(RVA = "0x1F4252C", Offset = "0x1F4252C", VA = "0x1F4252C")]
	public void PlayWithSkyBoard(ResourceID skyboardid)
	{
	}

	[Token(Token = "0x600A004")]
	[Address(RVA = "0x1F3AAB4", Offset = "0x1F3AAB4", VA = "0x1F3AAB4")]
	public void PlayGunAnim(GunType type)
	{
	}

	[Token(Token = "0x600A005")]
	[Address(RVA = "0x1F428D4", Offset = "0x1F428D4", VA = "0x1F428D4")]
	public void ForcePlayGunAnim(GunType type)
	{
	}

	[Token(Token = "0x600A006")]
	[Address(RVA = "0x1F42788", Offset = "0x1F42788", VA = "0x1F42788")]
	private void CalculateShowTime()
	{
	}

	[Token(Token = "0x600A007")]
	[Address(RVA = "0x1F34378", Offset = "0x1F34378", VA = "0x1F34378")]
	public void SetAvatarShowPoseInterval(uint avatarid)
	{
	}

	[Token(Token = "0x600A008")]
	[Address(RVA = "0x1F42970", Offset = "0x1F42970", VA = "0x1F42970")]
	public void PlayDoubleIdleAnim()
	{
	}

	[Token(Token = "0x600A009")]
	[Address(RVA = "0x1F42A7C", Offset = "0x1F42A7C", VA = "0x1F42A7C")]
	public void PlayStandIdle()
	{
	}

	[Token(Token = "0x600A00A")]
	[Address(RVA = "0x1F42BA0", Offset = "0x1F42BA0", VA = "0x1F42BA0")]
	public void PlayOnlyIdle()
	{
	}

	[Token(Token = "0x600A00B")]
	[Address(RVA = "0x1F42C54", Offset = "0x1F42C54", VA = "0x1F42C54")]
	public void StopPlayGunCoroutine()
	{
	}

	[Token(Token = "0x600A00C")]
	[Address(RVA = "0x1F42D0C", Offset = "0x1F42D0C", VA = "0x1F42D0C")]
	public void ResetAnimAvatar()
	{
	}

	[Token(Token = "0x600A00D")]
	[Address(RVA = "0x1F35374", Offset = "0x1F35374", VA = "0x1F35374")]
	public void StopGunAnim(bool stopCortine = false)
	{
	}

	[Token(Token = "0x600A00E")]
	[Address(RVA = "0x1F33620", Offset = "0x1F33620", VA = "0x1F33620")]
	private void UpdateShowingWepon()
	{
	}

	[Token(Token = "0x600A00F")]
	[Address(RVA = "0x1F42F48", Offset = "0x1F42F48", VA = "0x1F42F48")]
	private void ForceUpdateShowingWeapon()
	{
	}

	[Token(Token = "0x600A010")]
	[Address(RVA = "0x1F4321C", Offset = "0x1F4321C", VA = "0x1F4321C")]
	public void RequestSpawnBattleFlagOnHand()
	{
	}

	[Token(Token = "0x600A011")]
	[Address(RVA = "0x1F433C0", Offset = "0x1F433C0", VA = "0x1F433C0")]
	public void RequestSpawnBattleFlagOnGround()
	{
	}

	[Token(Token = "0x600A012")]
	[Address(RVA = "0x1F4343C", Offset = "0x1F4343C", VA = "0x1F4343C")]
	public void HideBattleFlagOnHand()
	{
	}

	[Token(Token = "0x600A013")]
	[Address(RVA = "0x1F37DF4", Offset = "0x1F37DF4", VA = "0x1F37DF4")]
	public void ClearCachedBattleFlag()
	{
	}

	[Token(Token = "0x600A014")]
	[Address(RVA = "0x1F43514", Offset = "0x1F43514", VA = "0x1F43514")]
	private void CacheTransforms(Transform tr, Dictionary<Transform, TransCache> map, bool clearParent)
	{
	}

	[Token(Token = "0x600A015")]
	[Address(RVA = "0x1F33854", Offset = "0x1F33854", VA = "0x1F33854")]
	protected void RebindPlayerAnimator()
	{
	}

	[Token(Token = "0x600A016")]
	[Address(RVA = "0x1F43938", Offset = "0x1F43938", VA = "0x1F43938")]
	public void EnableLookAt(EFrontendUIType uiType, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x600A017")]
	[Address(RVA = "0x1F34488", Offset = "0x1F34488", VA = "0x1F34488")]
	private void UpdateSetLookAt(CSSharedAvatarData aData)
	{
	}

	[Token(Token = "0x600A018")]
	[Address(RVA = "0x1F43D10", Offset = "0x1F43D10", VA = "0x1F43D10")]
	private void InitLookAtComponentWithAvatarData([Optional] CSSharedAvatarData aData, [Optional] AvatarLookAtData ldata, int uiType = -1, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x600A019")]
	[Address(RVA = "0x1F43DDC", Offset = "0x1F43DDC", VA = "0x1F43DDC")]
	public ResourceID GetUseResAnimaitonCtrlId()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A01A")]
	[Address(RVA = "0x1F43E34", Offset = "0x1F43E34", VA = "0x1F43E34", Slot = "42")]
	public virtual void UpdateAnimator(CSSharedAvatarData aData, bool female)
	{
	}

	[Token(Token = "0x600A01B")]
	[Address(RVA = "0x1F3AD38", Offset = "0x1F3AD38", VA = "0x1F3AD38")]
	private bool CheckCanRandomAnimClip(ResourceID id)
	{
		return default(bool);
	}

	[Token(Token = "0x600A01C")]
	[Address(RVA = "0x1F3B1B8", Offset = "0x1F3B1B8", VA = "0x1F3B1B8")]
	private AnimationClip GetSpeicalIdleAnimClip(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x600A01D")]
	[Address(RVA = "0x1F3B66C", Offset = "0x1F3B66C", VA = "0x1F3B66C")]
	private AnimationClip GetCommonIdleAnimClip(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x600A01E")]
	[Address(RVA = "0x1F3C3B8", Offset = "0x1F3C3B8", VA = "0x1F3C3B8")]
	protected AnimationClip LoadAnimClip(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x600A01F")]
	[Address(RVA = "0x1F3F208", Offset = "0x1F3F208", VA = "0x1F3F208")]
	public void ModifyAnimState()
	{
	}

	[Token(Token = "0x600A020")]
	[Address(RVA = "0x1F3C590", Offset = "0x1F3C590", VA = "0x1F3C590")]
	protected void OverrideAnimClip(AnimationClip clip, AnimationClip baseClip)
	{
	}

	[Token(Token = "0x600A021")]
	[Address(RVA = "0x1F3C190", Offset = "0x1F3C190", VA = "0x1F3C190")]
	public void PlayEffect(ResourceID id, AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
	{
	}

	[Token(Token = "0x600A022")]
	[Address(RVA = "0x1F44500", Offset = "0x1F44500", VA = "0x1F44500")]
	public void StartRecordIdle()
	{
	}

	[Token(Token = "0x600A023")]
	[Address(RVA = "0x1F3B860", Offset = "0x1F3B860", VA = "0x1F3B860")]
	public void ResetRecordIdle()
	{
	}

	[Token(Token = "0x600A024")]
	[Address(RVA = "0x1F4456C", Offset = "0x1F4456C", VA = "0x1F4456C")]
	public bool CanShowWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x600A025")]
	[Address(RVA = "0x1F445C4", Offset = "0x1F445C4", VA = "0x1F445C4")]
	public void OnAnimationVisibilityChanged(int visilbe)
	{
	}

	[Token(Token = "0x600A026")]
	[Address(RVA = "0x1F4463C", Offset = "0x1F4463C", VA = "0x1F4463C")]
	public void OnAnimEvent(PKNONKBDBBK e, object[] para)
	{
	}

	[Token(Token = "0x600A027")]
	[Address(RVA = "0x1F448A0", Offset = "0x1F448A0", VA = "0x1F448A0")]
	private void OnDisableDynamicBones()
	{
	}

	[Token(Token = "0x600A028")]
	[Address(RVA = "0x1F449F8", Offset = "0x1F449F8", VA = "0x1F449F8")]
	private void OnEnableDynamicBones()
	{
	}

	[Token(Token = "0x600A029")]
	[Address(RVA = "0x1F44B60", Offset = "0x1F44B60", VA = "0x1F44B60")]
	private void OnDisableFlux()
	{
	}

	[Token(Token = "0x600A02A")]
	[Address(RVA = "0x1F44C70", Offset = "0x1F44C70", VA = "0x1F44C70")]
	private void OnEnableFlux()
	{
	}

	[Token(Token = "0x600A02B")]
	[Address(RVA = "0x1F44DBC", Offset = "0x1F44DBC", VA = "0x1F44DBC")]
	public void SetAnimatorStatus(bool acitve)
	{
	}

	[Token(Token = "0x600A02C")]
	[Address(RVA = "0x1F451A0", Offset = "0x1F451A0", VA = "0x1F451A0")]
	public void HideDynamicCharacter()
	{
	}

	[Token(Token = "0x600A02D")]
	[Address(RVA = "0x1F45274", Offset = "0x1F45274", VA = "0x1F45274")]
	public void ShowDynamicCharacter()
	{
	}

	[Token(Token = "0x600A02E")]
	[Address(RVA = "0x1F452D8", Offset = "0x1F452D8", VA = "0x1F452D8")]
	public void DisableCharacterRoate()
	{
	}

	[Token(Token = "0x600A02F")]
	[Address(RVA = "0x1F4541C", Offset = "0x1F4541C", VA = "0x1F4541C")]
	public void EnableAvatarInputHandlerComp(bool flag)
	{
	}

	[Token(Token = "0x600A030")]
	[Address(RVA = "0x1F4554C", Offset = "0x1F4554C", VA = "0x1F4554C")]
	public void EnableCharacterRoate()
	{
	}

	[Token(Token = "0x600A031")]
	[Address(RVA = "0x1F4566C", Offset = "0x1F4566C", VA = "0x1F4566C")]
	public void KeepCharacterRotateState(int flag)
	{
	}

	[Token(Token = "0x600A032")]
	[Address(RVA = "0x1F456D8", Offset = "0x1F456D8", VA = "0x1F456D8")]
	public void ResetAvatarRotation()
	{
	}

	[Token(Token = "0x600A033")]
	[Address(RVA = "0x1F457FC", Offset = "0x1F457FC", VA = "0x1F457FC")]
	public void AnimationOver()
	{
	}

	[Token(Token = "0x600A034")]
	[Address(RVA = "0x1F45908", Offset = "0x1F45908", VA = "0x1F45908")]
	public void PlayIdleSkipEffect(GameObject prefab)
	{
	}

	[Token(Token = "0x600A035")]
	[Address(RVA = "0x1F46158", Offset = "0x1F46158", VA = "0x1F46158")]
	private void DestoryPaticleEffect()
	{
	}

	[Token(Token = "0x600A036")]
	[Address(RVA = "0x1F4647C", Offset = "0x1F4647C", VA = "0x1F4647C", Slot = "43")]
	public virtual void UpdateAnimationEvent(bool flag = true, bool effectFlag = true)
	{
	}

	[Token(Token = "0x600A037")]
	[Address(RVA = "0x1F45204", Offset = "0x1F45204", VA = "0x1F45204")]
	private void SetDynamicCharacterVisble(bool visble)
	{
	}

	[Token(Token = "0x600A038")]
	[Address(RVA = "0x1F38638", Offset = "0x1F38638", VA = "0x1F38638")]
	public void StopAnimEfects(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
	{
	}

	[Token(Token = "0x600A039")]
	[Address(RVA = "0x1F45A7C", Offset = "0x1F45A7C", VA = "0x1F45A7C")]
	public void PlaySkipEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
	{
	}

	[Token(Token = "0x600A03A")]
	[Address(RVA = "0x1F45D3C", Offset = "0x1F45D3C", VA = "0x1F45D3C")]
	public void PlayCommonIdleAnimEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
	{
	}

	[Token(Token = "0x600A03B")]
	[Address(RVA = "0x1F3934C", Offset = "0x1F3934C", VA = "0x1F3934C")]
	public void PlaySpeicalIdleAnimEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
	{
	}

	[Token(Token = "0x600A03C")]
	[Address(RVA = "0x1F464EC", Offset = "0x1F464EC", VA = "0x1F464EC")]
	public void SaveDoubleAnims(string doublespecial, string doubleidle)
	{
	}

	[Token(Token = "0x600A03D")]
	[Address(RVA = "0x1F3FAD8", Offset = "0x1F3FAD8", VA = "0x1F3FAD8")]
	private void SetDoubleAnims(string doublespecial, string doubleidle)
	{
	}

	[Token(Token = "0x600A03E")]
	[Address(RVA = "0x1F3B3AC", Offset = "0x1F3B3AC", VA = "0x1F3B3AC")]
	private void SetOverrideDoubleAnim(AnimationClip clip, string pattern)
	{
	}

	[Token(Token = "0x600A03F")]
	[Address(RVA = "0x1F4656C", Offset = "0x1F4656C", VA = "0x1F4656C")]
	private AnimationClip GetAnimClipByPattern(RuntimeAnimatorController controller, bool baseClip, string pattern)
	{
		return null;
	}

	[Token(Token = "0x600A040")]
	[Address(RVA = "0x1F469F0", Offset = "0x1F469F0", VA = "0x1F469F0")]
	private static bool _003CUpdateLobbyBackPackSlot_003Em__0(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A041")]
	[Address(RVA = "0x1F46A88", Offset = "0x1F46A88", VA = "0x1F46A88")]
	private static bool _003CUpdateLobbyBackPackSlot_003Em__1(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A042")]
	[Address(RVA = "0x1F46B20", Offset = "0x1F46B20", VA = "0x1F46B20")]
	private void _003CPlayAnimClipAtLobby_003Em__2()
	{
	}

	[Token(Token = "0x600A043")]
	[Address(RVA = "0x1F46B2C", Offset = "0x1F46B2C", VA = "0x1F46B2C")]
	private static bool _003CStartShowPose_003Em__3(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A044")]
	[Address(RVA = "0x1F46BC4", Offset = "0x1F46BC4", VA = "0x1F46BC4")]
	private static bool _003CInitGunShowTime_003Em__4(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A045")]
	[Address(RVA = "0x1F46CAC", Offset = "0x1F46CAC", VA = "0x1F46CAC")]
	private static bool _003CInitGunShowTime_003Em__5(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A046")]
	[Address(RVA = "0x1F46D94", Offset = "0x1F46D94", VA = "0x1F46D94")]
	private static bool _003CInitGunShowTime_003Em__6(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A047")]
	[Address(RVA = "0x1F46E7C", Offset = "0x1F46E7C", VA = "0x1F46E7C")]
	private static bool _003CInitGunShowTime_003Em__7(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A048")]
	[Address(RVA = "0x1F46F64", Offset = "0x1F46F64", VA = "0x1F46F64")]
	private static bool _003CInitGunShowTime_003Em__8(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A049")]
	[Address(RVA = "0x1F4704C", Offset = "0x1F4704C", VA = "0x1F4704C")]
	private static bool _003CInitGunShowTime_003Em__9(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A04A")]
	[Address(RVA = "0x1F47134", Offset = "0x1F47134", VA = "0x1F47134")]
	public void _003C_003EiFixBaseProxy_InitAvatar(bool P0, bool P1, int P2)
	{
	}

	[Token(Token = "0x600A04B")]
	[Address(RVA = "0x1F47154", Offset = "0x1F47154", VA = "0x1F47154")]
	public new void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}

	[Token(Token = "0x600A04C")]
	[Address(RVA = "0x1F4715C", Offset = "0x1F4715C", VA = "0x1F4715C")]
	public void _003C_003EiFixBaseProxy_OnSetAvatarDone(CSSharedAvatarData P0)
	{
	}

	[Token(Token = "0x600A04D")]
	[Address(RVA = "0x1F47164", Offset = "0x1F47164", VA = "0x1F47164")]
	public void _003C_003EiFixBaseProxy_ChangeRace(string P0)
	{
	}

	[Token(Token = "0x600A04E")]
	[Address(RVA = "0x1F4716C", Offset = "0x1F4716C", VA = "0x1F4716C")]
	public void _003C_003EiFixBaseProxy_ResetAvatar()
	{
	}
}
