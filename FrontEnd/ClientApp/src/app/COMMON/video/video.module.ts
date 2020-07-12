import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VideoComponent } from './video';

import { VgCoreModule } from 'videogular2/ngx-videogular/core';
import { VgControlsModule } from 'videogular2/controls';
import { VgOverlayPlayModule } from 'videogular2/overlay-play';
import { VgBufferingModule } from 'videogular2/buffering';

import { VgStreamingModule } from 'videogular2/streaming';
import { VgImaAdsModule } from 'videogular2/ima-ads';

// import { CoreModule } from '@videogular/ngx-videogular/core';
// import { ControlsModule } from '@videogular/ngx-videogular/controls';
// import { OverlayPlayModule } from '@videogular/ngx-videogular/overlay-play';
// import { BufferingModule } from '@videogular/ngx-videogular/buffering';

@NgModule({
  imports: [
      CommonModule,
      VgCoreModule,
      VgControlsModule,
      VgOverlayPlayModule,
      VgBufferingModule,
      VgStreamingModule,
      VgImaAdsModule
    ],
  declarations: [VideoComponent],
  exports: [VideoComponent]
})
export class VideoModule { }
