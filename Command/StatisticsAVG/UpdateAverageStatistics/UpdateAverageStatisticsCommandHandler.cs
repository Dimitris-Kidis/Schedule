﻿using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.StatisticsAVG.UpdateAverageStatistics
{
    public class UpdateAverageStatisticsCommandHandler : IRequestHandler<UpdateAverageStatisticsCommand, Unit>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.StatisticsAVG> _statsAVGRepository;
        public UpdateAverageStatisticsCommandHandler(ITypoRepository<ApplicationCore.Domain.Entities.StatisticsAVG> statsAVGRepository)
        {
            _statsAVGRepository = statsAVGRepository;
        }
        public Task<Unit> Handle(UpdateAverageStatisticsCommand request, CancellationToken cancellationToken)
        {
            var stats = _statsAVGRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();
            if (stats != null)
            {
                stats.AvgSymbolsPerMin = request.AvgSymbolsPerMin;
                stats.AvgAccuracy = request.AvgAccuracy;
                stats.AvgTime = request.AvgTime;
                stats.TextsCount = request.TextsCount;
                _statsAVGRepository.Update(stats);
                _statsAVGRepository.Save();
            }

            return Task.FromResult(new Unit());
        }
    }
}