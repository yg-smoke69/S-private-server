using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E73")]
internal interface IFFAudioEngine
{
	[Token(Token = "0x6019689")]
	bool PlayMusic(ResourceID resourceID, bool isFadeIn, bool isFadeOut, float startTime, bool isNoCache);

	[Token(Token = "0x601968A")]
	void StopMusic();

	[Token(Token = "0x601968B")]
	int InsertMusic(ResourceID resourceID);

	[Token(Token = "0x601968C")]
	bool CancelInsertMusic(int ticket);

	[Token(Token = "0x601968D")]
	int PlayMusicSubtrack(ResourceID resourceID);

	[Token(Token = "0x601968E")]
	bool StopMusicSubtrack(int ticket);

	[Token(Token = "0x601968F")]
	bool IsCurrentMusicExisit();

	[Token(Token = "0x6019690")]
	float GetCurrentMusicTime();

	[Token(Token = "0x6019691")]
	bool PlayCutScene(ResourceID resourceID, int audioMixerGroup, bool isLoop = false);

	[Token(Token = "0x6019692")]
	bool StopCutScene();

	[Token(Token = "0x6019693")]
	int PlayEmoteSound(ResourceID resourceID, bool isLoop = false);

	[Token(Token = "0x6019694")]
	bool StopEmoteSound(int ticket);

	[Token(Token = "0x6019695")]
	void PlaySoundEffect(ResourceID resourceID);

	[Token(Token = "0x6019696")]
	void PlayUserVoice();

	[Token(Token = "0x6019697")]
	int PlayCharacterVoice(ResourceID resourceID, [Optional] Action endCallback);

	[Token(Token = "0x6019698")]
	bool StopCharacterVoice(int ticket);

	[Token(Token = "0x6019699")]
	bool IsCharacterVoicePlaying(int ticket);

	[Token(Token = "0x601969A")]
	int Start2DLoop(ResourceID resourceID);

	[Token(Token = "0x601969B")]
	bool End2DLoop(int ticket);

	[Token(Token = "0x601969C")]
	void RunOneFrame(float deltaTime);

	[Token(Token = "0x601969D")]
	void SetMusicVolume(float vol);

	[Token(Token = "0x601969E")]
	void SetSoundVolume(float vol);

	[Token(Token = "0x601969F")]
	void SetVoiceVolume(float vol);

	[Token(Token = "0x60196A0")]
	void SetMusicOn(bool isMuted);

	[Token(Token = "0x60196A1")]
	void SetSoundOn(bool isMuted);
}
