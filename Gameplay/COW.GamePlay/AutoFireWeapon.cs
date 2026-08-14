using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005A6")]
public class AutoFireWeapon : Entity
{
	[Token(Token = "0x20005A7")]
	private sealed class HEDHJPHCOCF : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4004360")]
		[FieldOffset(Offset = "0x8")]
		internal Player JALLMHKLNLG;

		[Token(Token = "0x4004361")]
		[FieldOffset(Offset = "0xC")]
		internal AutoFireWeapon GADHAMJEKIM;

		[Token(Token = "0x4004362")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4004363")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4004364")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170002D4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x1144D58", Offset = "0x1144D58", VA = "0x1144D58", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x1144D60", Offset = "0x1144D60", VA = "0x1144D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600226A")]
		[Address(RVA = "0x1143B30", Offset = "0x1143B30", VA = "0x1143B30")]
		public HEDHJPHCOCF()
		{
		}

		[Token(Token = "0x600226B")]
		[Address(RVA = "0x1144B20", Offset = "0x1144B20", VA = "0x1144B20", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600226E")]
		[Address(RVA = "0x1144D68", Offset = "0x1144D68", VA = "0x1144D68", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600226F")]
		[Address(RVA = "0x1144D7C", Offset = "0x1144D7C", VA = "0x1144D7C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400435A")]
	[FieldOffset(Offset = "0x34")]
	private AutoFireWeaponData BOPLAOANKBI;

	[Token(Token = "0x400435B")]
	[FieldOffset(Offset = "0x38")]
	private GameObject PJBOFJPMCJB;

	[Token(Token = "0x400435C")]
	[FieldOffset(Offset = "0x3C")]
	public Transform FirePointTF;

	[Token(Token = "0x400435D")]
	[FieldOffset(Offset = "0x40")]
	private bool FKCCEBCJIAP;

	[Token(Token = "0x400435E")]
	[FieldOffset(Offset = "0x44")]
	private ResourceID IHKFKOOHADP;

	[Token(Token = "0x400435F")]
	[FieldOffset(Offset = "0x48")]
	private float NJJNMFHHKNC;

	[Token(Token = "0x600225C")]
	[Address(RVA = "0x114309C", Offset = "0x114309C", VA = "0x114309C")]
	public AutoFireWeapon()
	{
	}

	[Token(Token = "0x600225D")]
	[Address(RVA = "0x114312C", Offset = "0x114312C", VA = "0x114312C", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600225E")]
	[Address(RVA = "0x11438B8", Offset = "0x11438B8", VA = "0x11438B8", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x600225F")]
	[Address(RVA = "0x11439E8", Offset = "0x11439E8", VA = "0x11439E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002260")]
	[Address(RVA = "0x1143A64", Offset = "0x1143A64", VA = "0x1143A64")]
	private IEnumerator OIPBABJMIIA()
	{
		return null;
	}

	[Token(Token = "0x6002261")]
	[Address(RVA = "0x1143B38", Offset = "0x1143B38", VA = "0x1143B38")]
	private void NMKNJFLOLOD(Vector3 NFCLOPBEKGN)
	{
	}

	[Token(Token = "0x6002262")]
	[Address(RVA = "0x1143DC4", Offset = "0x1143DC4", VA = "0x1143DC4")]
	private void PDBIOJCNIHG(GameObject NPGPGOFBFDN, Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x6002263")]
	[Address(RVA = "0x11441E4", Offset = "0x11441E4", VA = "0x11441E4")]
	private void FHKINKFJCNE(ref RaycastHit GFFMCONFDCD, MADMMIICBNN JEEIBOEGGPD)
	{
	}

	[Token(Token = "0x6002264")]
	[Address(RVA = "0x1144354", Offset = "0x1144354", VA = "0x1144354")]
	private void KFLNPHNAMDG(Vector3 BNDPJDJAFOM, Player IDPKNJIFJOM)
	{
	}

	[Token(Token = "0x6002265")]
	[Address(RVA = "0x11449FC", Offset = "0x11449FC", VA = "0x11449FC")]
	private void Reset()
	{
	}

	[Token(Token = "0x6002266")]
	[Address(RVA = "0x1144A58", Offset = "0x1144A58", VA = "0x1144A58")]
	public AutoFireWeaponData GetData()
	{
		return null;
	}

	[Token(Token = "0x6002267")]
	[Address(RVA = "0x1144AB0", Offset = "0x1144AB0", VA = "0x1144AB0")]
	public void SetGameStart(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6002268")]
	[Address(RVA = "0x1144B10", Offset = "0x1144B10", VA = "0x1144B10")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002269")]
	[Address(RVA = "0x1144B18", Offset = "0x1144B18", VA = "0x1144B18")]
	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
