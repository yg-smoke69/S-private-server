using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200091A")]
internal interface AEPAPLNNAHF
{
	[Token(Token = "0x17000433")]
	IHAAMHPPLMG IHAAMHPPLMG
	{
		[Token(Token = "0x6003F86")]
		get;
	}

	[Token(Token = "0x17000434")]
	OPILIBBOEAC AEMHIOJGMBP
	{
		[Token(Token = "0x6003F96")]
		get;
	}

	[Token(Token = "0x17000435")]
	Player LNLKCHLDGPF
	{
		[Token(Token = "0x6003F9D")]
		get;
	}

	[Token(Token = "0x6003F84")]
	List<Vector3> GetBoundingBoxList();

	[Token(Token = "0x6003F85")]
	GameObject GetGameObject();

	[Token(Token = "0x6003F87")]
	bool IsInVehicle();

	[Token(Token = "0x6003F88")]
	Vehicle VehicleIAmIn();

	[Token(Token = "0x6003F89")]
	bool IsPassengerInVehicleCanFire();

	[Token(Token = "0x6003F8A")]
	bool IsOnStrop();

	[Token(Token = "0x6003F8B")]
	bool IsOnChair();

	[Token(Token = "0x6003F8C")]
	bool IsInCatapult();

	[Token(Token = "0x6003F8D")]
	bool IsOnGrapplingHook();

	[Token(Token = "0x6003F8E")]
	bool IsOnHook();

	[Token(Token = "0x6003F8F")]
	bool IsOnVMEHook();

	[Token(Token = "0x6003F90")]
	bool HasGrapplingHook();

	[Token(Token = "0x6003F91")]
	bool HasHook();

	[Token(Token = "0x6003F92")]
	bool HasVMEHook();

	[Token(Token = "0x6003F93")]
	LevelStrop GetStropIAmOn();

	[Token(Token = "0x6003F94")]
	AAHMJHHPECM GetItemOnHand();

	[Token(Token = "0x6003F95")]
	AAHMJHHPECM GetRealItemOnHand();

	[Token(Token = "0x6003F97")]
	bool HasHeuristicTarget();

	[Token(Token = "0x6003F98")]
	bool IsTargetFriend(OPILIBBOEAC FFDHFKIMFDG);

	[Token(Token = "0x6003F99")]
	bool HeuristicTargetIsFriend();

	[Token(Token = "0x6003F9A")]
	bool GetSightingState();

	[Token(Token = "0x6003F9B")]
	bool IsSightingUIAvailable();

	[Token(Token = "0x6003F9C")]
	void OnSightingUIStateChange(bool HNFJGOBEMKM, float HCIFNBGLHIF);
}
