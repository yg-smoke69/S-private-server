using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E78")]
internal interface IAvatarVoice
{
	[Token(Token = "0x600929B")]
	bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB);

	[Token(Token = "0x600929C")]
	void StopAvatarVoiceShot();
}
