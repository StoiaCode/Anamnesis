﻿// © Anamnesis.
// Licensed under the MIT license.

namespace Anamnesis.Actor.Refresh;

using System.Threading.Tasks;
using Anamnesis.Memory;
using static Anamnesis.Memory.ActorBasicMemory;

public class AnamnesisActorRefresher : IActorRefresher
{
	public bool CanRefresh(ActorMemory actor)
	{
		// Ana can't refresh gpose actors
		if (actor.IsGPoseActor)
			return false;

		return true;
	}

	public async Task RefreshActor(ActorMemory actor)
	{
		await Task.Delay(16);

		actor.RenderMode = RenderModes.Unload;
		await Task.Delay(75);
		actor.RenderMode = RenderModes.Draw;

		await Task.Delay(150);
	}
}
