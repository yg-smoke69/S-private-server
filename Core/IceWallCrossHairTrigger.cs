using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005CC")]
public class IceWallCrossHairTrigger : MonoBehaviour
{
	[Token(Token = "0x40043DB")]
	[FieldOffset(Offset = "0xC")]
	public bool CheckPlayer;

	[Token(Token = "0x40043DC")]
	[FieldOffset(Offset = "0xD")]
	public bool CheckVehicle;

	[Token(Token = "0x40043DD")]
	[FieldOffset(Offset = "0xE")]
	public bool CheckCannon;

	[Token(Token = "0x40043DE")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<IHAAMHPPLMG, List<Collider>> mPlayersInside;

	[Token(Token = "0x40043DF")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, List<Collider>> mVehiclesInside;

	[Token(Token = "0x40043E0")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, List<Collider>> mCannonsInside;

	[Token(Token = "0x40043E1")]
	[FieldOffset(Offset = "0x1C")]
	private bool mAreaOccupied;

	[Token(Token = "0x170002DF")]
	public bool AreaOccupied
	{
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x31093F4", Offset = "0x31093F4", VA = "0x31093F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600230E")]
	[Address(RVA = "0x3107D7C", Offset = "0x3107D7C", VA = "0x3107D7C")]
	public IceWallCrossHairTrigger()
	{
	}

	[Token(Token = "0x600230F")]
	[Address(RVA = "0x3107E64", Offset = "0x3107E64", VA = "0x3107E64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002310")]
	[Address(RVA = "0x3108070", Offset = "0x3108070", VA = "0x3108070")]
	private void Start()
	{
	}

	[Token(Token = "0x6002311")]
	[Address(RVA = "0x31081FC", Offset = "0x31081FC", VA = "0x31081FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002312")]
	[Address(RVA = "0x3108388", Offset = "0x3108388", VA = "0x3108388")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x6002313")]
	[Address(RVA = "0x3108568", Offset = "0x3108568", VA = "0x3108568")]
	private void OnVehicleDead(object[] data)
	{
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0x3108780", Offset = "0x3108780", VA = "0x3108780")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0x3108E64", Offset = "0x3108E64", VA = "0x3108E64")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0x3107F3C", Offset = "0x3107F3C", VA = "0x3107F3C")]
	private void OnObjInsideChanged()
	{
	}
}
