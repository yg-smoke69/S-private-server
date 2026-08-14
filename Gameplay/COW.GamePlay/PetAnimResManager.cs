using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000874")]
public class PetAnimResManager : MonoBehaviour
{
	[Token(Token = "0x2000875")]
	private class BNMEMLBJACL
	{
		[Token(Token = "0x4005311")]
		[FieldOffset(Offset = "0x8")]
		public object JGHEGHHINPA;

		[Token(Token = "0x4005312")]
		[FieldOffset(Offset = "0xC")]
		public uint LDHDANHPAIF;

		[Token(Token = "0x4005313")]
		[FieldOffset(Offset = "0x10")]
		public ResourceID GJADIFOFGPM;

		[Token(Token = "0x4005314")]
		[FieldOffset(Offset = "0x14")]
		public CHGFLCMGBFP HPKFIJAKGKN;

		[Token(Token = "0x4005315")]
		[FieldOffset(Offset = "0x18")]
		public Action<CHGFLCMGBFP> NKJFEBHCBPA;

		[Token(Token = "0x6003B87")]
		[Address(RVA = "0xBCDD6C", Offset = "0xBCDD6C", VA = "0xBCDD6C")]
		public BNMEMLBJACL()
		{
		}
	}

	[Token(Token = "0x400530D")]
	[FieldOffset(Offset = "0x0")]
	private static PetAnimResManager AOAKGOMAOJP;

	[Token(Token = "0x400530E")]
	[FieldOffset(Offset = "0xC")]
	private IResourceRefCacheWithOwner PKBPJBLPOND;

	[Token(Token = "0x400530F")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<object, BNMEMLBJACL> FPJAJBKABGH;

	[Token(Token = "0x4005310")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, BNMEMLBJACL> ECONOMLMOMD;

	[Token(Token = "0x1700041A")]
	public static PetAnimResManager NAHILPCMBNM
	{
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0xBC985C", Offset = "0xBC985C", VA = "0xBC985C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003B71")]
	[Address(RVA = "0xBCCC44", Offset = "0xBCCC44", VA = "0xBCCC44")]
	public PetAnimResManager()
	{
	}

	[Token(Token = "0x6003B73")]
	[Address(RVA = "0xBCCC4C", Offset = "0xBCCC4C", VA = "0xBCCC4C")]
	private void DPLMGOJKKCM()
	{
	}

	[Token(Token = "0x6003B74")]
	[Address(RVA = "0xBCCD94", Offset = "0xBCCD94", VA = "0xBCCD94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003B75")]
	[Address(RVA = "0xBCCEE8", Offset = "0xBCCEE8", VA = "0xBCCEE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B76")]
	[Address(RVA = "0xBCD010", Offset = "0xBCD010", VA = "0xBCD010")]
	private void CFACDIHMPPL()
	{
	}

	[Token(Token = "0x6003B77")]
	[Address(RVA = "0xBC99F4", Offset = "0xBC99F4", VA = "0xBC99F4")]
	public Dictionary<uint, List<CHGFLCMGBFP>> CreateAnimDic(object FIMNKGABILM, PetData AJKBOONEOAB, List<PetActionData> DMIGDBBAMPD)
	{
		return null;
	}

	[Token(Token = "0x6003B78")]
	[Address(RVA = "0xBCD288", Offset = "0xBCD288", VA = "0xBCD288")]
	public Object GetResource(object FIMNKGABILM, ResourceID FCMOICILFBP)
	{
		return null;
	}

	[Token(Token = "0x6003B79")]
	[Address(RVA = "0xBCD140", Offset = "0xBCD140", VA = "0xBCD140")]
	public void RegisterResource(object FIMNKGABILM, Object ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6003B7A")]
	[Address(RVA = "0xBCA618", Offset = "0xBCA618", VA = "0xBCA618")]
	public void ReleaseResources(object FIMNKGABILM)
	{
	}

	[Token(Token = "0x6003B7B")]
	[Address(RVA = "0xBCAA28", Offset = "0xBCAA28", VA = "0xBCAA28")]
	public bool LoadAnimClip(object FIMNKGABILM, CHGFLCMGBFP ILMPMIJAOKA)
	{
		return default(bool);
	}

	[Token(Token = "0x6003B7C")]
	[Address(RVA = "0xBCD3D0", Offset = "0xBCD3D0", VA = "0xBCD3D0")]
	public AnimationClip GetAnimClip(object FIMNKGABILM, ResourceID FCMOICILFBP)
	{
		return null;
	}

	[Token(Token = "0x6003B7D")]
	[Address(RVA = "0xBCD620", Offset = "0xBCD620", VA = "0xBCD620")]
	private BNMEMLBJACL MGJJIOMLBIB(object FIMNKGABILM)
	{
		return null;
	}

	[Token(Token = "0x6003B7E")]
	[Address(RVA = "0xBCD700", Offset = "0xBCD700", VA = "0xBCD700")]
	private void LDGJDKBNKCJ(BNMEMLBJACL ILMPMIJAOKA)
	{
	}

	[Token(Token = "0x6003B7F")]
	[Address(RVA = "0xBCD890", Offset = "0xBCD890", VA = "0xBCD890")]
	private void JEAGLHKELDH(object FIMNKGABILM, uint LPFMNBCHJPE)
	{
	}

	[Token(Token = "0x6003B80")]
	[Address(RVA = "0xBCAF6C", Offset = "0xBCAF6C", VA = "0xBCAF6C")]
	public void CancelAsyncRequrests(object FIMNKGABILM)
	{
	}

	[Token(Token = "0x6003B81")]
	[Address(RVA = "0xBCD9A4", Offset = "0xBCD9A4", VA = "0xBCD9A4")]
	private void DJLLCEFKJJB(object FIMNKGABILM, uint LPFMNBCHJPE)
	{
	}

	[Token(Token = "0x6003B82")]
	[Address(RVA = "0xBCA7D0", Offset = "0xBCA7D0", VA = "0xBCA7D0")]
	public void PreloadIfNotLoading(object FIMNKGABILM, ResourceID FCMOICILFBP)
	{
	}

	[Token(Token = "0x6003B83")]
	[Address(RVA = "0xBCAFF0", Offset = "0xBCAFF0", VA = "0xBCAFF0")]
	public void LoadAnimClipAsyncOnceAtATime(object FIMNKGABILM, CHGFLCMGBFP ILMPMIJAOKA, Action<CHGFLCMGBFP> IBJIDAEAKED)
	{
	}

	[Token(Token = "0x6003B84")]
	[Address(RVA = "0xBCDAF8", Offset = "0xBCDAF8", VA = "0xBCDAF8")]
	private void BDCNGHLFNFL(object FIMNKGABILM, ResourceID FCMOICILFBP, CHGFLCMGBFP ILMPMIJAOKA, Action<CHGFLCMGBFP> IBJIDAEAKED)
	{
	}

	[Token(Token = "0x6003B85")]
	[Address(RVA = "0xBCDD74", Offset = "0xBCDD74", VA = "0xBCDD74")]
	private void PNCBEMKKMCK(uint LPFMNBCHJPE, Object ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6003B86")]
	[Address(RVA = "0xBCE170", Offset = "0xBCE170", VA = "0xBCE170")]
	private bool JFMENHNGJHN(CHGFLCMGBFP ILMPMIJAOKA, Object ECINOMEHBKA)
	{
		return default(bool);
	}
}
