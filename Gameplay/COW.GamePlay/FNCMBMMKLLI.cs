using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200093D")]
internal class FNCMBMMKLLI : _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x200093E")]
	public enum IALJILGPBEL
	{
		[Token(Token = "0x4005589")]
		FOLLOW_LOCK,
		[Token(Token = "0x400558A")]
		OVERLOOK
	}

	[Token(Token = "0x4005573")]
	protected const uint MKLPDBFENAC = 1u;

	[Token(Token = "0x4005574")]
	protected const uint LFJMNJIPINO = 2u;

	[Token(Token = "0x4005575")]
	protected const uint EGCCKHNBENN = 4u;

	[Token(Token = "0x4005576")]
	protected const uint FDJKHCAPPFP = 8u;

	[Token(Token = "0x4005577")]
	[FieldOffset(Offset = "0x0")]
	protected static Quaternion FODEEOHCPKI;

	[Token(Token = "0x4005578")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003CEGGDHBFMIMB_003Ek__BackingField;

	[Token(Token = "0x4005579")]
	[FieldOffset(Offset = "0x10")]
	private IHAAMHPPLMG _003CNIMFIBIBPDG_003Ek__BackingField;

	[Token(Token = "0x400557A")]
	[FieldOffset(Offset = "0x28")]
	private Player NJMDHHGDNPJ;

	[Token(Token = "0x400557B")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG _003CMEINKMDHOMJ_003Ek__BackingField;

	[Token(Token = "0x400557C")]
	[FieldOffset(Offset = "0x48")]
	private bool _003CEBGJMFEJHKM_003Ek__BackingField;

	[Token(Token = "0x400557D")]
	[FieldOffset(Offset = "0x4C")]
	private GBIFIIGGDGB _003CPEKANNIACDH_003Ek__BackingField;

	[Token(Token = "0x400557E")]
	[FieldOffset(Offset = "0x50")]
	private bool JLMBBMILMBH;

	[Token(Token = "0x400557F")]
	[FieldOffset(Offset = "0x51")]
	public bool HPLBAHJAOKH;

	[Token(Token = "0x4005580")]
	[FieldOffset(Offset = "0x52")]
	private bool BGOAACMIKMI;

	[Token(Token = "0x4005581")]
	[FieldOffset(Offset = "0x54")]
	private uint ONKHAHGLHFG;

	[Token(Token = "0x4005582")]
	[FieldOffset(Offset = "0x58")]
	private IALJILGPBEL GMMECEDMPMH;

	[Token(Token = "0x4005583")]
	[FieldOffset(Offset = "0x5C")]
	private JADJBFDFEHA LMFFNPPOAGL;

	[Token(Token = "0x4005584")]
	[FieldOffset(Offset = "0x60")]
	private uint EAMBEAEMLBJ;

	[Token(Token = "0x4005585")]
	[FieldOffset(Offset = "0x64")]
	private AudioResource OEIDBPJAFHE;

	[Token(Token = "0x4005586")]
	[FieldOffset(Offset = "0x68")]
	private AudioResource LDPJOPNGNKC;

	[Token(Token = "0x4005587")]
	[FieldOffset(Offset = "0x6C")]
	private AudioResource ELKHHIIMOCP;

	[Token(Token = "0x1700045B")]
	public ulong MIJOCMKONAD
	{
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x192C9D4", Offset = "0x192C9D4", VA = "0x192C9D4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60040D7")]
		[Address(RVA = "0x192C9DC", Offset = "0x192C9DC", VA = "0x192C9DC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700045C")]
	public IHAAMHPPLMG IHAAMHPPLMG
	{
		[Token(Token = "0x60040D8")]
		[Address(RVA = "0x192C9EC", Offset = "0x192C9EC", VA = "0x192C9EC", Slot = "17")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x60040D9")]
		[Address(RVA = "0x192CA04", Offset = "0x192CA04", VA = "0x192CA04")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700045D")]
	public Player GEMHAAHJBBD
	{
		[Token(Token = "0x60040DA")]
		[Address(RVA = "0x192CA38", Offset = "0x192CA38", VA = "0x192CA38", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60040DB")]
		[Address(RVA = "0x192CA90", Offset = "0x192CA90", VA = "0x192CA90")]
		set
		{
		}
	}

	[Token(Token = "0x1700045E")]
	public IHAAMHPPLMG OFNCAKPLFPP
	{
		[Token(Token = "0x60040DC")]
		[Address(RVA = "0x192CD88", Offset = "0x192CD88", VA = "0x192CD88", Slot = "5")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x60040DD")]
		[Address(RVA = "0x192CDA0", Offset = "0x192CDA0", VA = "0x192CDA0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x1700045F")]
	public bool DEAJHINCGKB
	{
		[Token(Token = "0x60040DE")]
		[Address(RVA = "0x192CDD4", Offset = "0x192CDD4", VA = "0x192CDD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60040DF")]
		[Address(RVA = "0x192CDDC", Offset = "0x192CDDC", VA = "0x192CDDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000460")]
	public GBIFIIGGDGB CIFKIFFELLC
	{
		[Token(Token = "0x60040E0")]
		[Address(RVA = "0x192CDE4", Offset = "0x192CDE4", VA = "0x192CDE4")]
		get
		{
			return default(GBIFIIGGDGB);
		}
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x192CDEC", Offset = "0x192CDEC", VA = "0x192CDEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000461")]
	public uint NBCPHEIMLNL
	{
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x192CDF4", Offset = "0x192CDF4", VA = "0x192CDF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000462")]
	public IHAAMHPPLMG GHHENFFJPHK
	{
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x192CE54", Offset = "0x192CE54", VA = "0x192CE54")]
		get
		{
			return default(IHAAMHPPLMG);
		}
	}

	[Token(Token = "0x17000463")]
	public OPILIBBOEAC AEMHIOJGMBP
	{
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x192DB4C", Offset = "0x192DB4C", VA = "0x192DB4C", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000464")]
	public Player LNLKCHLDGPF
	{
		[Token(Token = "0x6004127")]
		[Address(RVA = "0x1935198", Offset = "0x1935198", VA = "0x1935198", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040D5")]
	[Address(RVA = "0x192C9CC", Offset = "0x192C9CC", VA = "0x192C9CC")]
	public FNCMBMMKLLI()
	{
	}

	[Token(Token = "0x60040E4")]
	[Address(RVA = "0x192CFC0", Offset = "0x192CFC0", VA = "0x192CFC0", Slot = "20")]
	public bool IsPassengerInVehicleCanFire()
	{
		return default(bool);
	}

	[Token(Token = "0x60040E5")]
	[Address(RVA = "0x192CB88", Offset = "0x192CB88", VA = "0x192CB88")]
	private void GKLDBBFBEBP()
	{
	}

	[Token(Token = "0x60040E6")]
	[Address(RVA = "0x192CC84", Offset = "0x192CC84", VA = "0x192CC84")]
	private void EONIAFMMMMK()
	{
	}

	[Token(Token = "0x60040E7")]
	[Address(RVA = "0x192D4F4", Offset = "0x192D4F4", VA = "0x192D4F4")]
	private void HJLJBGILNDB(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60040E8")]
	[Address(RVA = "0x192D87C", Offset = "0x192D87C", VA = "0x192D87C")]
	private void KFNMHLFBIAP(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60040E9")]
	[Address(RVA = "0x192D328", Offset = "0x192D328", VA = "0x192D328")]
	private void KHOCLLCJKBL()
	{
	}

	[Token(Token = "0x60040EA")]
	[Address(RVA = "0x192D6B4", Offset = "0x192D6B4", VA = "0x192D6B4")]
	private void KHOCLLCJKBL(ref AudioResource LHLMBBIBDLB, ResourceID KMIPBIGPDPI, bool CGHMPOEIMMP)
	{
	}

	[Token(Token = "0x60040EB")]
	[Address(RVA = "0x192DA40", Offset = "0x192DA40", VA = "0x192DA40")]
	private void AHJPHGABDAM()
	{
	}

	[Token(Token = "0x60040ED")]
	[Address(RVA = "0x192DC5C", Offset = "0x192DC5C", VA = "0x192DC5C", Slot = "34")]
	public bool HasHeuristicTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x60040EE")]
	[Address(RVA = "0x192DD6C", Offset = "0x192DD6C", VA = "0x192DD6C", Slot = "36")]
	public bool HeuristicTargetIsFriend()
	{
		return default(bool);
	}

	[Token(Token = "0x60040EF")]
	[Address(RVA = "0x192DE7C", Offset = "0x192DE7C", VA = "0x192DE7C")]
	public static FNCMBMMKLLI ENBAAICLBFA(ulong HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND, IHAAMHPPLMG FDFMALLNBJK, GBIFIIGGDGB MECMCGOMJGF, float FADEMGOJGHB)
	{
		return null;
	}

	[Token(Token = "0x60040F0")]
	[Address(RVA = "0x192E164", Offset = "0x192E164", VA = "0x192E164")]
	public void DPLMGOJKKCM()
	{
	}

	[Token(Token = "0x60040F1")]
	[Address(RVA = "0x192EACC", Offset = "0x192EACC", VA = "0x192EACC")]
	private void MCJMFABEGGH()
	{
	}

	[Token(Token = "0x60040F2")]
	[Address(RVA = "0x192F4E8", Offset = "0x192F4E8", VA = "0x192F4E8")]
	private void CIAGEFMBAKJ()
	{
	}

	[Token(Token = "0x60040F3")]
	[Address(RVA = "0x1930360", Offset = "0x1930360", VA = "0x1930360")]
	public void FHIPMICEPMI()
	{
	}

	[Token(Token = "0x60040F4")]
	[Address(RVA = "0x1930540", Offset = "0x1930540", VA = "0x1930540")]
	private void OCILOFGOMKE()
	{
	}

	[Token(Token = "0x60040F5")]
	[Address(RVA = "0x1930A48", Offset = "0x1930A48", VA = "0x1930A48")]
	private void NGEDDDJEHCK(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60040F6")]
	[Address(RVA = "0x19314B8", Offset = "0x19314B8", VA = "0x19314B8")]
	public void PPLMKEJJHFO()
	{
	}

	[Token(Token = "0x60040F7")]
	[Address(RVA = "0x1931638", Offset = "0x1931638", VA = "0x1931638", Slot = "12")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x60040F8")]
	[Address(RVA = "0x1931760", Offset = "0x1931760", VA = "0x1931760", Slot = "10")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60040F9")]
	[Address(RVA = "0x19318E0", Offset = "0x19318E0", VA = "0x19318E0", Slot = "11")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60040FA")]
	[Address(RVA = "0x1931A68", Offset = "0x1931A68", VA = "0x1931A68", Slot = "13")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x60040FB")]
	[Address(RVA = "0x1931AE8", Offset = "0x1931AE8", VA = "0x1931AE8", Slot = "14")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60040FC")]
	[Address(RVA = "0x1931BF8", Offset = "0x1931BF8", VA = "0x1931BF8", Slot = "15")]
	public List<Vector3> GetBoundingBoxList()
	{
		return null;
	}

	[Token(Token = "0x60040FD")]
	[Address(RVA = "0x1931C78", Offset = "0x1931C78", VA = "0x1931C78", Slot = "16")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x60040FE")]
	[Address(RVA = "0x1931D88", Offset = "0x1931D88", VA = "0x1931D88", Slot = "37")]
	public bool GetSightingState()
	{
		return default(bool);
	}

	[Token(Token = "0x60040FF")]
	[Address(RVA = "0x1931EA0", Offset = "0x1931EA0", VA = "0x1931EA0", Slot = "38")]
	public bool IsSightingUIAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6004100")]
	[Address(RVA = "0x1931F14", Offset = "0x1931F14", VA = "0x1931F14")]
	private void JBLPHHHOINO()
	{
	}

	[Token(Token = "0x6004101")]
	[Address(RVA = "0x1932044", Offset = "0x1932044", VA = "0x1932044", Slot = "39")]
	public void OnSightingUIStateChange(bool HNFJGOBEMKM, float HCIFNBGLHIF)
	{
	}

	[Token(Token = "0x6004102")]
	[Address(RVA = "0x1932380", Offset = "0x1932380", VA = "0x1932380", Slot = "35")]
	public bool IsTargetFriend(OPILIBBOEAC FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x6004103")]
	[Address(RVA = "0x1930200", Offset = "0x1930200", VA = "0x1930200")]
	private void KCELHEPBKAF()
	{
	}

	[Token(Token = "0x6004104")]
	[Address(RVA = "0x192FA5C", Offset = "0x192FA5C", VA = "0x192FA5C")]
	private void LLELGPLFFEI()
	{
	}

	[Token(Token = "0x6004105")]
	[Address(RVA = "0x192FE38", Offset = "0x192FE38", VA = "0x192FE38")]
	private void CPCLOKPNCBJ()
	{
	}

	[Token(Token = "0x6004106")]
	[Address(RVA = "0x192FBD4", Offset = "0x192FBD4", VA = "0x192FBD4")]
	private void PCCGLPOIAAI()
	{
	}

	[Token(Token = "0x6004107")]
	[Address(RVA = "0x192FF90", Offset = "0x192FF90", VA = "0x192FF90")]
	private void BMMHDKDNJKF()
	{
	}

	[Token(Token = "0x6004108")]
	[Address(RVA = "0x19300F4", Offset = "0x19300F4", VA = "0x19300F4")]
	private void IEAFELPDOMG()
	{
	}

	[Token(Token = "0x6004109")]
	[Address(RVA = "0x19329D8", Offset = "0x19329D8", VA = "0x19329D8")]
	private void NGGAPCFAIIF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600410A")]
	[Address(RVA = "0x1932B8C", Offset = "0x1932B8C", VA = "0x1932B8C")]
	private void NDMEJAPDNHA(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600410B")]
	[Address(RVA = "0x1932D40", Offset = "0x1932D40", VA = "0x1932D40")]
	private void LBCDKICJNFM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600410C")]
	[Address(RVA = "0x1932EF4", Offset = "0x1932EF4", VA = "0x1932EF4")]
	private void FOPAEMLDINJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600410D")]
	[Address(RVA = "0x19330A8", Offset = "0x19330A8", VA = "0x19330A8")]
	private void JCOFNKFDCHG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600410E")]
	[Address(RVA = "0x193325C", Offset = "0x193325C", VA = "0x193325C")]
	private void LPIMHLMDEED(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600410F")]
	[Address(RVA = "0x19333F8", Offset = "0x19333F8", VA = "0x19333F8")]
	private void EDFJMDDDIIM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004110")]
	[Address(RVA = "0x19335F8", Offset = "0x19335F8", VA = "0x19335F8", Slot = "31")]
	public AAHMJHHPECM GetItemOnHand()
	{
		return null;
	}

	[Token(Token = "0x6004111")]
	[Address(RVA = "0x1933708", Offset = "0x1933708", VA = "0x1933708", Slot = "32")]
	public AAHMJHHPECM GetRealItemOnHand()
	{
		return null;
	}

	[Token(Token = "0x6004112")]
	[Address(RVA = "0x1933818", Offset = "0x1933818", VA = "0x1933818", Slot = "18")]
	public bool IsInVehicle()
	{
		return default(bool);
	}

	[Token(Token = "0x6004113")]
	[Address(RVA = "0x192D218", Offset = "0x192D218", VA = "0x192D218", Slot = "19")]
	public Vehicle VehicleIAmIn()
	{
		return null;
	}

	[Token(Token = "0x6004114")]
	[Address(RVA = "0x1933928", Offset = "0x1933928", VA = "0x1933928", Slot = "21")]
	public bool IsOnStrop()
	{
		return default(bool);
	}

	[Token(Token = "0x6004115")]
	[Address(RVA = "0x1933A38", Offset = "0x1933A38", VA = "0x1933A38", Slot = "22")]
	public bool IsOnChair()
	{
		return default(bool);
	}

	[Token(Token = "0x6004116")]
	[Address(RVA = "0x1933B48", Offset = "0x1933B48", VA = "0x1933B48", Slot = "23")]
	public bool IsInCatapult()
	{
		return default(bool);
	}

	[Token(Token = "0x6004117")]
	[Address(RVA = "0x1933C58", Offset = "0x1933C58", VA = "0x1933C58")]
	public bool NEANJGGKKDG()
	{
		return default(bool);
	}

	[Token(Token = "0x6004118")]
	[Address(RVA = "0x1933D68", Offset = "0x1933D68", VA = "0x1933D68", Slot = "24")]
	public bool IsOnGrapplingHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004119")]
	[Address(RVA = "0x1933E78", Offset = "0x1933E78", VA = "0x1933E78", Slot = "26")]
	public bool IsOnVMEHook()
	{
		return default(bool);
	}

	[Token(Token = "0x600411A")]
	[Address(RVA = "0x1933F88", Offset = "0x1933F88", VA = "0x1933F88", Slot = "25")]
	public bool IsOnHook()
	{
		return default(bool);
	}

	[Token(Token = "0x600411B")]
	[Address(RVA = "0x1934098", Offset = "0x1934098", VA = "0x1934098", Slot = "27")]
	public bool HasGrapplingHook()
	{
		return default(bool);
	}

	[Token(Token = "0x600411C")]
	[Address(RVA = "0x19341A8", Offset = "0x19341A8", VA = "0x19341A8", Slot = "28")]
	public bool HasHook()
	{
		return default(bool);
	}

	[Token(Token = "0x600411D")]
	[Address(RVA = "0x19342B8", Offset = "0x19342B8", VA = "0x19342B8", Slot = "29")]
	public bool HasVMEHook()
	{
		return default(bool);
	}

	[Token(Token = "0x600411E")]
	[Address(RVA = "0x19343C8", Offset = "0x19343C8", VA = "0x19343C8")]
	public bool LPIJDKICPHJ()
	{
		return default(bool);
	}

	[Token(Token = "0x600411F")]
	[Address(RVA = "0x19344D8", Offset = "0x19344D8", VA = "0x19344D8", Slot = "30")]
	public LevelStrop GetStropIAmOn()
	{
		return null;
	}

	[Token(Token = "0x6004120")]
	[Address(RVA = "0x19345E8", Offset = "0x19345E8", VA = "0x19345E8")]
	public void HHMFMAEGBLB(ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004121")]
	[Address(RVA = "0x192E59C", Offset = "0x192E59C", VA = "0x192E59C", Slot = "8")]
	public void BIHLCIFBFIN(bool OCKBMCMIHKJ)
	{
	}

	[Token(Token = "0x6004122")]
	[Address(RVA = "0x1934BEC", Offset = "0x1934BEC", VA = "0x1934BEC")]
	public void GHPOCJPNLLK(IHAAMHPPLMG BECFAIOFONM)
	{
	}

	[Token(Token = "0x6004123")]
	[Address(RVA = "0x1930C74", Offset = "0x1930C74", VA = "0x1930C74")]
	public void BKBGKJFKBFD(IHAAMHPPLMG BIFFAIEPIND, bool HMHJOKKECKO)
	{
	}

	[Token(Token = "0x6004124")]
	[Address(RVA = "0x1934E6C", Offset = "0x1934E6C", VA = "0x1934E6C")]
	public bool LKAIONPIKMG()
	{
		return default(bool);
	}

	[Token(Token = "0x6004125")]
	[Address(RVA = "0x1934F74", Offset = "0x1934F74", VA = "0x1934F74", Slot = "9")]
	public void MAFEBNOPFPH()
	{
	}

	[Token(Token = "0x6004126")]
	[Address(RVA = "0x1931528", Offset = "0x1931528", VA = "0x1931528")]
	private void MOFCCFLJDKM()
	{
	}

	[Token(Token = "0x6004128")]
	[Address(RVA = "0x19351F8", Offset = "0x19351F8", VA = "0x19351F8")]
	public void MKNEFFDNGKP(JADJBFDFEHA PMGBACFJIHO, uint NMAJCLPMCDN)
	{
	}

	[Token(Token = "0x6004129")]
	[Address(RVA = "0x192F9F4", Offset = "0x192F9F4", VA = "0x192F9F4")]
	private void BADHPLGJJPO()
	{
	}

	[Token(Token = "0x600412A")]
	[Address(RVA = "0x1935368", Offset = "0x1935368", VA = "0x1935368")]
	private void FFOBGMBNOFB(JADJBFDFEHA PMGBACFJIHO, uint NMAJCLPMCDN)
	{
	}

	[Token(Token = "0x600412B")]
	[Address(RVA = "0x1935628", Offset = "0x1935628", VA = "0x1935628")]
	public void MIPLNPMCBHK(IALJILGPBEL HPKCDJLHEFO)
	{
	}

	[Token(Token = "0x600412C")]
	[Address(RVA = "0x1935694", Offset = "0x1935694", VA = "0x1935694")]
	public IALJILGPBEL NKCHINBFJHN()
	{
		return default(IALJILGPBEL);
	}

	[Token(Token = "0x600412D")]
	[Address(RVA = "0x19356EC", Offset = "0x19356EC", VA = "0x19356EC")]
	public void AOKKFLMMHKJ()
	{
	}

	[Token(Token = "0x600412E")]
	[Address(RVA = "0x1935938", Offset = "0x1935938", VA = "0x1935938")]
	public void MPABGCGFOKC()
	{
	}
}
