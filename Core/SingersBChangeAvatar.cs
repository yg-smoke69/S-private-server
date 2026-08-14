using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200046F")]
public class SingersBChangeAvatar : MonoBehaviour
{
	[Token(Token = "0x2000470")]
	private sealed class _003CChangeAvatarEnu_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4003CFF")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<IHAAMHPPLMG, Player> _003CplayersDict_003E__0;

		[Token(Token = "0x4003D00")]
		[FieldOffset(Offset = "0xC")]
		internal WaitForSeconds _003CwaitOneSeconds_003E__0;

		[Token(Token = "0x4003D01")]
		[FieldOffset(Offset = "0x10")]
		internal int _003Cindex_003E__0;

		[Token(Token = "0x4003D02")]
		[FieldOffset(Offset = "0x18")]
		internal Dictionary<IHAAMHPPLMG, Player>.ValueCollection.Enumerator _0024locvar0;

		[Token(Token = "0x4003D03")]
		[FieldOffset(Offset = "0x48")]
		internal Player _003Cplayer_003E__1;

		[Token(Token = "0x4003D04")]
		[FieldOffset(Offset = "0x4C")]
		internal ModelData _003Cmodel_003E__2;

		[Token(Token = "0x4003D05")]
		[FieldOffset(Offset = "0x50")]
		internal int _003Ci_003E__3;

		[Token(Token = "0x4003D06")]
		[FieldOffset(Offset = "0x54")]
		internal SingersBClothDanceConfigData _003CcurConfig_003E__4;

		[Token(Token = "0x4003D07")]
		[FieldOffset(Offset = "0x58")]
		internal int _003Cdataindex_003E__4;

		[Token(Token = "0x4003D08")]
		[FieldOffset(Offset = "0x5C")]
		internal bool _003CisReady_003E__4;

		[Token(Token = "0x4003D09")]
		[FieldOffset(Offset = "0x60")]
		internal uint[] _0024locvar1;

		[Token(Token = "0x4003D0A")]
		[FieldOffset(Offset = "0x64")]
		internal int _0024locvar2;

		[Token(Token = "0x4003D0B")]
		[FieldOffset(Offset = "0x68")]
		internal ModelData _003Cmodel_003E__4;

		[Token(Token = "0x4003D0C")]
		[FieldOffset(Offset = "0x6C")]
		internal SingersBChangeAvatar _0024this;

		[Token(Token = "0x4003D0D")]
		[FieldOffset(Offset = "0x70")]
		internal object _0024current;

		[Token(Token = "0x4003D0E")]
		[FieldOffset(Offset = "0x74")]
		internal bool _0024disposing;

		[Token(Token = "0x4003D0F")]
		[FieldOffset(Offset = "0x78")]
		internal int _0024PC;

		[Token(Token = "0x170001F7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6001653")]
			[Address(RVA = "0x21D1720", Offset = "0x21D1720", VA = "0x21D1720", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001654")]
			[Address(RVA = "0x21D1728", Offset = "0x21D1728", VA = "0x21D1728", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x21D043C", Offset = "0x21D043C", VA = "0x21D043C")]
		public _003CChangeAvatarEnu_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6001652")]
		[Address(RVA = "0x21D0E4C", Offset = "0x21D0E4C", VA = "0x21D0E4C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001655")]
		[Address(RVA = "0x21D1730", Offset = "0x21D1730", VA = "0x21D1730", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001656")]
		[Address(RVA = "0x21D17B0", Offset = "0x21D17B0", VA = "0x21D17B0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003CF8")]
	[FieldOffset(Offset = "0xC")]
	public List<ModelData> models;

	[Token(Token = "0x4003CF9")]
	[FieldOffset(Offset = "0x10")]
	public Transform characters;

	[Token(Token = "0x4003CFA")]
	[FieldOffset(Offset = "0x14")]
	public SharedColorTable SkinColor;

	[Token(Token = "0x4003CFB")]
	[FieldOffset(Offset = "0x18")]
	public bool excute;

	[Token(Token = "0x4003CFC")]
	[FieldOffset(Offset = "0x1C")]
	private SingersBClothDanceConfigManager configMgr;

	[Token(Token = "0x4003CFD")]
	[FieldOffset(Offset = "0x20")]
	public int maxPlayerNum;

	[Token(Token = "0x4003CFE")]
	[FieldOffset(Offset = "0x24")]
	public GAGILKKDDMJ UseQuality;

	[Token(Token = "0x6001647")]
	[Address(RVA = "0x21CFE44", Offset = "0x21CFE44", VA = "0x21CFE44")]
	public SingersBChangeAvatar()
	{
	}

	[Token(Token = "0x6001648")]
	[Address(RVA = "0x21CFED8", Offset = "0x21CFED8", VA = "0x21CFED8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001649")]
	[Address(RVA = "0x21D0020", Offset = "0x21D0020", VA = "0x21D0020")]
	public void Load(object[] param)
	{
	}

	[Token(Token = "0x600164A")]
	[Address(RVA = "0x21D01A4", Offset = "0x21D01A4", VA = "0x21D01A4")]
	public void Active(object[] param)
	{
	}

	[Token(Token = "0x600164B")]
	[Address(RVA = "0x21D03FC", Offset = "0x21D03FC", VA = "0x21D03FC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600164C")]
	[Address(RVA = "0x21D0400", Offset = "0x21D0400", VA = "0x21D0400")]
	public void Update()
	{
	}

	[Token(Token = "0x600164D")]
	[Address(RVA = "0x21D0120", Offset = "0x21D0120", VA = "0x21D0120")]
	private IEnumerator ChangeAvatarEnu()
	{
		return null;
	}

	[Token(Token = "0x600164E")]
	[Address(RVA = "0x21D0444", Offset = "0x21D0444", VA = "0x21D0444")]
	public void ChangeAvatar()
	{
	}

	[Token(Token = "0x600164F")]
	[Address(RVA = "0x21D0AE8", Offset = "0x21D0AE8", VA = "0x21D0AE8")]
	private void Change(Player player, ModelData data)
	{
	}

	[Token(Token = "0x6001650")]
	[Address(RVA = "0x21D0BF8", Offset = "0x21D0BF8", VA = "0x21D0BF8")]
	private void ChangeCloth(ModelData data, SingersBClothDanceConfigData config)
	{
	}
}
