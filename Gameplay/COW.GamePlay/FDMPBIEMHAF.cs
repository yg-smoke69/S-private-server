using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200097D")]
internal interface FDMPBIEMHAF
{
	[Token(Token = "0x600488B")]
	GameObject GameObject();

	[Token(Token = "0x600488C")]
	void RegisterPlayer(Player BNDGMFKDCII, GameObject APOIADLOOAH);

	[Token(Token = "0x600488D")]
	void UnregisterPlayer();

	[Token(Token = "0x600488E")]
	Player GetPlayer();

	[Token(Token = "0x600488F")]
	void UpdateSkill(float OPKNJGBDOBB, float OMAFEKBHOAA);

	[Token(Token = "0x6004890")]
	void OnActSkillFinished(KBJIDDDPPOO GEPIPPKAIBK);

	[Token(Token = "0x6004891")]
	void TryToCastActSkillByIndex(int HHLONFLCJBL, bool IMGAECDPPCF);

	[Token(Token = "0x6004892")]
	void PlaySkillPhaseAnim(string FIHEJIKOFMM);

	[Token(Token = "0x6004893")]
	void OnPlayerPlayAnim(AnimationID MFNEABEJJCB);

	[Token(Token = "0x6004894")]
	void SetColliderEnable(bool MCDIDHODHLN, int NFIFPONEOID);

	[Token(Token = "0x6004895")]
	bool IsRunningSkill();

	[Token(Token = "0x6004896")]
	bool CheckSkillCanCast(int HHLONFLCJBL);
}
