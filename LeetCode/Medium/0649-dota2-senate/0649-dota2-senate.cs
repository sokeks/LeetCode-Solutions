public class Solution {
    public string PredictPartyVictory(string senate) {
        Span<char> span = senate.Length >= 1024 ? new char[senate.Length] : stackalloc char[senate.Length];
        senate.AsSpan().CopyTo(span);
        return PredictPartyVictory(span);
    }

    public string PredictPartyVictory(Span<char> senate) {
        var roundSurvivingDires = 0;
        var roundSurvivingRadiants = 0;

        var floatingBanForDires = 0;
        var floatingBanForRadiants = 0;

        const char radiantSenator = 'R';
        const char direSenator = 'D';
        const char tombstone = 'x';
        while (true)
        {
            for (var i = 0; i < senate.Length; i++)
            {
                if (senate[i] == radiantSenator)
                {
                    if (floatingBanForRadiants > 0)
                    {
                        senate[i] = tombstone;
                        floatingBanForRadiants--;
                    }
                    else
                    {
                        roundSurvivingRadiants++;
                        floatingBanForDires++;
                    }
                }
                else if (senate[i] == direSenator)
                {
                    if (floatingBanForDires > 0)
                    {
                        senate[i] = tombstone;
                        floatingBanForDires--;
                    }
                    else
                    {
                        roundSurvivingDires++;
                        floatingBanForRadiants++;
                    }
                }
            }

            if (roundSurvivingDires != 0 && roundSurvivingRadiants != 0)
            {
                roundSurvivingDires = 0;
                roundSurvivingRadiants = 0;
            }
            else
            {
                break;
            }
        }

        return roundSurvivingDires == 0 ? "Radiant" : "Dire";
    }



    // public string PredictPartyVictory(string senate) {
    //     var radiantPositions = new Queue<int>(senate.Length);
    //     var direPositions = new Queue<int>(senate.Length);
        
    //     const char radiantSenator = 'R';
    //     const char direSenator = 'D';
    //     for (var i = 0; i < senate.Length; i++)
    //     {
    //         if (senate[i] == radiantSenator)
    //         {
    //             radiantPositions.Enqueue(i);
    //         }
    //         else
    //         {
    //             direPositions.Enqueue(i);
    //         }            
    //     }

    //     while (radiantPositions.Count > 0 && direPositions.Count > 0)
    //     {
    //         var rPosition = radiantPositions.Dequeue();
    //         var dPosition = direPositions.Dequeue();

    //         if (rPosition < dPosition)
    //         {
    //             radiantPositions.Enqueue(rPosition + senate.Length);
    //         }
    //         else
    //         {
    //             direPositions.Enqueue(dPosition + senate.Length);
    //         }
    //     }
        
    //     return radiantPositions.Count > 0 ? "Radiant" : "Dire";
    // }
}